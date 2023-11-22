//using System;
//using System.Collections.Generic;
//using DTO;
//using MySql.Data.MySqlClient;
//using Org.BouncyCastle.Crypto.Generators;

//namespace DAL
//{
//    public partial class ProductOldDAO : DBConnection
//    {
//        private static readonly string dbInfoTableName = "product_info";
//        private static Product ConvertToInfoDTO(List<object> row)
//        {
//            try
//            {
//                Product obj = new ProductInfo(Convert.ToInt16(row[0]), Convert.ToString(row[1]))
//                {
//                    Name = Convert.ToString(row[2]),
//                    Category = CategoryDAO.Select(Convert.ToInt16(row[3])),
//                    Manufacturer = ManufacturerDAO.Select(Convert.ToInt16(row[4])),
//                    MadeIn = CountryDAO.Select(Convert.ToInt16(row[5])),
//                    Expiry = Convert.ToByte(row[6]),
//                    Unit = UnitDAO.Select(Convert.ToInt16(row[7])),
//                    StorageCondition = Convert.ToString(row[8]),
//                    Note = Convert.ToString(row[9]),
//                    Image = Convert.ToString(row[10])
//                };

//                var table = ExecuteReader("SELECT * FROM product_extra_ingredient WHERE product_id = " + obj.Id);
//                foreach (var r in table)
//                {
//                    obj.AddIngredient(SubstanceDAO.Select(Convert.ToInt16(r[1])), (float)r[2]);
//                }
//                return obj;
//            }
//            catch { return null; }
//        }

//        //public static List<ProductInfo> SelectAll()
//        //{
//        //    string sql = string.Format("SELECT * FROM {0} WHERE is_existing = true", dbTableName);
//        //    var table = ExecuteReader(sql);
//        //    var list = new List<ProductInfo>();
//        //    foreach (var row in table)
//        //    {
//        //        list.Add(ConvertToDTO(row));
//        //    }
//        //    return list;
//        //}

//        public static Product GetInformation(int id)
//        {
//            string sql = string.Format("SELECT * FROM {0} WHERE id = {1} AND is_existing = true", dbInfoTableName, id);
//            var table = ExecuteReader(sql);
//            return table.Count != 0 ? ConvertToInfoDTO(table[table.Count - 1]) : null;
//        }

//        public static int GetProductId(string barCode)
//        {
//            if (string.IsNullOrEmpty(barCode)) { return 0; }
//            string sql = string.Format("SELECT id FROM {0} WHERE code = '{1}' AND is_existing = true", dbInfoTableName, barCode);
//            return Convert.ToInt16(ExecuteScalar(sql));
//        }
//        private static bool Insert(Product e)
//        {
//            if (Open())
//            {
//                var trans = conn.BeginTransaction();
//                var cmd = new MySqlCommand
//                {
//                    Connection = conn,
//                    Transaction = trans
//                };
//                //var cmd = conn.CreateCommand();
//                //cmd.Transaction = trans;

//                try
//                {
//                    cmd.CommandText =
//                        "INSERT INTO product_info(code,name,category_id,manufacturer_id,made_in,expiry,unit_id,storage_condition,note,image) " +
//                        "VALUES (@code,@name,@category_id,@manufacturer_id,@made_in,@expiry,@unit_id,@storage_condition,@note,@image)";
//                    cmd.Parameters.AddWithValue("@code", e.Barcode);
//                    cmd.Parameters.AddWithValue("@name", e.Name);
//                    cmd.Parameters.AddWithValue("@category_id", e.Category.Id);
//                    cmd.Parameters.AddWithValue("@manufacturer_id", e.Manufacturer.Id);
//                    cmd.Parameters.AddWithValue("@made_in", e.MadeIn);
//                    cmd.Parameters.AddWithValue("@expiry", e.Expiry);
//                    cmd.Parameters.AddWithValue("@unit_id", e.Unit.Id);
//                    cmd.Parameters.AddWithValue("@storage_condition", e.StorageCondition);
//                    cmd.Parameters.AddWithValue("@note", e.Note);
//                    cmd.Parameters.AddWithValue("@image", e.Image);
//                    cmd.ExecuteNonQuery();

//                    cmd.CommandText =
//                        "SELECT auto_increment FROM information_schema.tables WHERE table_name='product_info'";
//                    int id = (int)cmd.ExecuteScalar() - 1;

//                    foreach (var i in e.ActiveIngredient)
//                    {
//                        cmd.CommandText = "INSERT INTO product_extra_ingredient VALUES (@product_id,@ingredient_id,@dosage)";
//                        cmd.Parameters.AddWithValue("@product_id", id);
//                        cmd.Parameters.AddWithValue("@ingredient_id", i.Key.Id);
//                        cmd.Parameters.AddWithValue("@dosage", i.Value);
//                        cmd.ExecuteNonQuery();
//                    }

//                    trans.Commit();
//                    return true;
//                }
//                catch
//                {
//                    trans.Rollback();
//                    return false;
//                }
//                finally { Close(); }
//            }
//            return false;
//        }

//        private static bool Update(Product e)
//        {
//            if (Open())
//            {
//                var trans = conn.BeginTransaction();
//                var cmd = new MySqlCommand
//                {
//                    Connection = conn,
//                    Transaction = trans
//                };
//                //var cmd = conn.CreateCommand();
//                //cmd.Transaction = trans;

//                try
//                {
//                    cmd.CommandText = "UPDATE product_info SET" +
//                        "name=@name," +
//                        "category_id=@category_id," +
//                        "manufacturer_id=@manufacturer_id," +
//                        "made_in=@made_in," +
//                        "expiry=@expiry," +
//                        "unit_id=@unit_id," +
//                        "storage_condition=@storage_condition," +
//                        "note=@note," +
//                        "image=@image WHERE id=@id)";
//                    cmd.Parameters.AddWithValue("@id", e.Id);
//                    cmd.Parameters.AddWithValue("@name", e.Name);
//                    cmd.Parameters.AddWithValue("@category_id", e.Category.Id);
//                    cmd.Parameters.AddWithValue("@manufacturer_id", e.Manufacturer.Id);
//                    cmd.Parameters.AddWithValue("@made_in", e.MadeIn);
//                    cmd.Parameters.AddWithValue("@expiry", e.Expiry);
//                    cmd.Parameters.AddWithValue("@unit_id", e.Unit.Id);
//                    cmd.Parameters.AddWithValue("@storage_condition", e.StorageCondition);
//                    cmd.Parameters.AddWithValue("@note", e.Note);
//                    cmd.Parameters.AddWithValue("@image", e.Image);
//                    cmd.ExecuteNonQuery();

//                    cmd.CommandText = "DELETE FROM product_extra_ingredient WHERE product_id=" + Convert.ToString(e.Id);
//                    cmd.ExecuteNonQuery();

//                    foreach (var i in e.ActiveIngredient)
//                    {
//                        cmd.CommandText = "INSERT INTO product_extra_ingredient VALUES (@product_id,@ingredient_id,@dosage)";
//                        cmd.Parameters.AddWithValue("@product_id", e.Id);
//                        cmd.Parameters.AddWithValue("@ingredient_id", i.Key.Id);
//                        cmd.Parameters.AddWithValue("@dosage", i.Value);
//                        cmd.ExecuteNonQuery();
//                    }

//                    trans.Commit();
//                    return true;
//                }
//                catch
//                {
//                    trans.Rollback();
//                    return false;
//                }
//                finally { Close(); }
//            }
//            return false;
//        }

//    }
//}