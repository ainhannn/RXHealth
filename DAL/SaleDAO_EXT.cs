using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Crypto.Generators;

namespace DAL
{
	public partial class SaleDAO : DBConnection
	{
		public static int CountByCustomer(int cusId)
		{
			string sql = String.Format(
			   "SELECT COUNT(id) FROM {0} " +
			   "WHERE customer_id = {1}", dbViewName, cusId);
			return Convert.ToInt16(ExecuteScalar(sql));
		}

		public static List<SaleInvoice> GetOnCustomer(int cusId)
		{
			string sql = string.Format(
				"SELECT * FROM {0} " +
				"WHERE customer_id = {1}", dbViewName, cusId);
			var table = ExecuteReader(sql);
			var list = new List<SaleInvoice>();
			foreach (var row in table)
			{
				list.Add(ConvertToDTO(row));
			}
			return list;
		}

		public static int GetPointOnCustomer2(string cusName)
		{
			string sql = string.Format(
				"SELECT sale_invoice.point FROM {0} " +
				"INNER JOIN customer ON sale_invoice.customer_id = customer.id " +
				"WHERE customer.contact_number = {1}", dbTableName, cusName);
			object result = ExecuteScalar(sql);
			return result != null ? Convert.ToInt32(result) : -1;
			//var list = new List<SaleInvoice>();
			//foreach (var row in table)
			//{
			//	list.Add(ConvertToDTO(row));
			//}
			//return list;
		}
	}
}