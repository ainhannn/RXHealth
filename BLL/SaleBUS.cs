using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public partial class SaleBUS
	{
		public List<SaleInvoice> getSelectAllForm()
		{
			return SaleDAO.SelectAllForm() != null ? SaleDAO.SelectAllForm() : null;
		}

		public static bool InsertInvoice(SaleInvoice e)
		{
			return SaleDAO.Insert(e);
		}

		public List<SaleInvoice> OnCustomer(int cusId)
		{
			return SaleDAO.GetOnCustomer(cusId);
		}

		public static int getCountByCustomer(int cusId)
		{
			return SaleDAO.CountByCustomer(cusId);
		}

	}
}
