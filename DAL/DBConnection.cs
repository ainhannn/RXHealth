using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DBConnection
    {
        private static string server = "localhost";
        private static string database = "PHARMACY";
        private static string user = "root";
        private static string password = "";
        protected static MySqlConnection conn;

        private static bool Open()
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

        private static void Close()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                }
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
                catch (MySqlException ex)
                {
                    return table;
                }
                finally
                {
                    Close();
                }
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
                    return cmd.ExecuteScalar();
                }
                catch (MySqlException ex)
                {
                    return null;
                }
                finally
                {
                    Close();
                }
            }
            return null;
        }

        // -1 if have error else an interger number of rows changed 
        protected static int ExecuteNonQuery(string sql)
        {
            if (Open())
            {
                try
                {
                    var cmd = new MySqlCommand(sql, conn);
                    return cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    return -1;
                }
                finally
                {
                    Close();
                }
            }
            return -1;
        }
    }
}