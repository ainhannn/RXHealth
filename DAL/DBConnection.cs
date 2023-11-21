using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
namespace DAL
{
    public class DBConnection
    {
        private static readonly string server = "localhost";
        private static readonly string database = "PHARMACY";
        private static readonly string user = "root";
        private static readonly string password = "";
        protected static MySqlConnection conn;

        protected static bool Open()
        {
            try
            {
                string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", server, database, user, password);
                conn = new MySqlConnection(connstring);
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        protected static void Close()
        {
            try
            {
                conn?.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // null if have error else table
        protected static List<List<object>> ExecuteReader(string sql)
        {
            var table = new List<List<object>>();
            if (Open())
            {
                try
                {
                    var cmd = new MySqlCommand(sql, conn);
                    //var cmd = conn.CreateCommand();
                    //cmd.CommandText = sql;
                    var rd = cmd.ExecuteReader();
                    int size = rd.FieldCount;
                    while (rd.Read())
                    {
                        var row = new List<object>();
                        for (int i = 0; i < size; i++)
                        {
                            row.Add(rd.GetValue(i));
                        }
                        table.Add(row);
                    }
                }
                catch { return new List<List<object>>(); }
                finally { Close(); }
            }
            return table;
        }

        // return an object
        protected static object ExecuteScalar(string sql)
        {
            if (Open())
            {
                try
                {
                    var cmd = new MySqlCommand(sql, conn);
                    var rd = cmd.ExecuteScalar();
                    return rd != DBNull.Value ? rd : null;
                }
                catch { return null; }
                finally { Close(); }
            }
            return null;
        }

        // -1 if have error else an integer number of rows changed
        protected static int ExecuteNonQuery(string sql)
        {
            if (Open())
            {
                try
                {
                    var cmd = new MySqlCommand(sql, conn);
                    return cmd.ExecuteNonQuery();
                }
                catch { return -1; }
                finally { Close(); }
            }
            return -1;
        }
    }
}
