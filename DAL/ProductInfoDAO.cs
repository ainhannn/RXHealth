﻿using System;
using System.Collections.Generic;
using DTO;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;

namespace DAL
{
    public class ProductInfoDAO : DBConnection
    {
        private static string dbTableName = "product_info";
        private static ProductInfo ConvertToDTO(List<object> row)
        {
            try
            {
                ProductInfo obj = new ProductInfo(Convert.ToInt16(row[0]), Convert.ToString(row[1]))
                {
                    Name = Convert.ToString(row[2]),
                    Category = CategoryDAO.Select(Convert.ToInt16(row[3])),
                    Manufacturer = ManufacturerDAO.Select(Convert.ToInt16(row[4])),
                    MadeIn = CountryDAO.Select(Convert.ToInt16(row[5])),
                    Expiry = Convert.ToByte(row[6]),
                    Unit = UnitDAO.Select(Convert.ToInt16(row[7])),
                    StorageCondition = Convert.ToString(row[8]),
                    Note = Convert.ToString(row[9]),
                    Image = Convert.ToString(row[10])
                };

                var table = ExecuteReader("SELECT * FROM product_extra_ingredient WHERE product_id = " + obj.Id);
                foreach (var r in table)
                {
                    obj.AddIngredient(IngredientDAO.Select(Convert.ToInt16(r[1])), (float)r[2]);
                }
                return obj;
            } catch { return null; }
        }

        public static List<ProductInfo> SelectAll()
        {
            string sql = string.Format("SELECT * FROM {0} WHERE is_existing = 'true'", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<ProductInfo>();
            foreach (var row in table) 
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }

        public static ProductInfo Select(int id)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE id = {1} AND is_existing = 'true'", dbTableName, id);
            var table = ExecuteReader(sql);
            return table.Count != 0 ? ConvertToDTO(table[table.Count - 1]) : null;
        }

        public static ProductInfo Select(string barCode)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE code = '{1}' AND is_existing = 'true'", dbTableName, barCode);
            var table = ExecuteReader(sql);
            return table.Count != 0 ? ConvertToDTO(table[table.Count - 1]) : null;
        }

        //public static List<ProductInfo> Search(string key)
        //{
        //    return new List<ProductInfo>();
        //}

        public static bool Insert(ProductInfo e)
        {
            if (Open())
            {
                var trans = conn.BeginTransaction();
                var cmd = new MySqlCommand
                {
                    Connection = conn,
                    Transaction = trans
                };
                //var cmd = conn.CreateCommand();
                //cmd.Transaction = trans;

                try
                {  
                    cmd.CommandText = 
                        "INSERT INTO {0}(code,name,category_id,manufacturer_id,made_in,expiry,unit_id,storage_condition,note,image) " +
                        "VALUES (@code,@name,@category_id,@manufacturer_id,@made_in,@expiry,@unit_id,@storage_condition,@note,@image)";
                    cmd.Parameters.AddWithValue("@code", e.Code);
                    cmd.Parameters.AddWithValue("@name", e.Name);
                    cmd.Parameters.AddWithValue("@category_id", e.Category.Id);
                    cmd.Parameters.AddWithValue("@manufacturer_id", e.Manufacturer.Id);
                    cmd.Parameters.AddWithValue("@made_in", e.MadeIn);
                    cmd.Parameters.AddWithValue("@expiry", e.Expiry);
                    cmd.Parameters.AddWithValue("@unit_id", e.Unit.Id);
                    cmd.Parameters.AddWithValue("@storage_condition", e.StorageCondition);
                    cmd.Parameters.AddWithValue("@note", e.Note);
                    cmd.Parameters.AddWithValue("@image", e.Image);

                    cmd.ExecuteNonQuery();

                    var sql = string.Format("");
                    cmd.CommandText = "";
                    cmd.ExecuteNonQuery();

                    trans.Commit();
                    return true;
                }
                catch 
                {
                    trans.Rollback();
                    return false; 
                }
                finally { Close(); }
            }
            return false;
        }

        public static bool Update(ProductInfo e)
        {
            string sql = string.Format("CALL product_info_insert('{1}',{2},{3},{4},{5},{6},'{7}','{8}','{9}')",
                dbTableName,
                e.Name,
                e.Category.Id,
                e.Manufacturer.Id,
                e.MadeIn.Id,
                e.Expiry,
                e.Unit.Id,
                e.StorageCondition,
                e.Note,
                e.Image);
            return ExecuteNonQuery(sql) > 0;
        }
    }
}