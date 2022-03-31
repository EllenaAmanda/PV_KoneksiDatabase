/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 31/03/2022
 * Time: 10.56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace KasirBaru_Pertemuan7
{
	/// <summary>
	/// Description of koneksi.
	/// </summary>
	class koneksi
	{
		public SqlConnection GetConn()
		{
			SqlConnection Conn = new SqlConnection();
			Conn.ConnectionString = "Data Source=DESKTOP-DRJE9BF\\SQLEXPRESS; initial catalog=kasir; integrated security=true;";
			return Conn;
		}
	}
}
