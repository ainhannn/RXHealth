using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class SubstanceBUS
    {
        public static List<string> SelectAll()
        {
            var list = new List<string>();
            foreach (var e in SubstanceDAO.SelectAll())
            {
                list.Add(e.Name);
            }
            return list;
        }
    }
}
