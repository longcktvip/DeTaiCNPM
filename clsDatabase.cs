using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace DeTai_QuanLyNhanVien_NamLong
{
    class clsDatabase
    {

        string conStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLSach;Integrated Security=True";
        SqlConnection con = new SqlConnection();
        public Boolean connectToDatabase()
        {
            try
            {
                if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
                {
                    con.ConnectionString = conStr;
                    con.Open();
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Loi ket noi CSDL!");
                return false;
            }
        }

        public DataTable getData(string selectStr)
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(selectStr, con);
            da.Fill(tbl);
            return tbl;
        }


    } 
}
