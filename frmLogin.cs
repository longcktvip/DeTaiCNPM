using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai_QuanLyNhanVien_NamLong
{
    public partial class frmLogin : Form
    {
        clsDatabase dt = new clsDatabase();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!dt.connectToDatabase()) return;

            string userName = txtUser.Text;
            string userPass = txtPassword.Text;

            string queryStr = "select * from TaiKhoan where uName = '" + userName 
                            +"' and uPassword = '" + userPass + "'";

            DataTable existsAcc = dt.getData(queryStr);

            if(existsAcc.Rows.Count == 1)
            {
                this.Hide();
                frmMain main = new frmMain();
                main.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Tai Khoan hoac mat khau khong hop le!!");
            }


        }
    }
}
