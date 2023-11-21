using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Request_resetDAO : DBConnection
    {
        private static readonly string dbTableName = "reset_request_tmp";
        public static List<int> selectAll()
        {
            string sql = string.Format("SELECT * FROM {0}", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<int>();
            try
            {
                foreach (var row in table)
                {
                    list.Add(Convert.ToInt16(row[0]));
                    Console.WriteLine(table[0][0] +"");
                }
                return list;
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public static bool Insert(int id)
        {
            string sql = string.Format("INSERT INTO {0} (id) VALUES ({1})", dbTableName, id);
            return ExecuteNonQuery(sql) > 0;
        }

        public static bool Delete(int id)
        {
            string sql = string.Format("DELETE FROM {0} WHERE id = {1}", dbTableName, id);
            return ExecuteNonQuery(sql) > 0;
        }
    }
}
