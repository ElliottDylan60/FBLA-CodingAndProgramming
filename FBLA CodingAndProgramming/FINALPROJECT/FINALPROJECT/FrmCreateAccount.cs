using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FINALPROJECT
{
    public partial class FrmCreateAccount : Form
    {
        public FrmCreateAccount(string ConnectionString)
        {
            InitializeComponent();
            LbConnectionString.Text = ConnectionString;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string query = "Insert into StudentInformation (Username,Password,FirstName,LastName,Grade,Student,Librarian,Admin) Values(@Username,@Password,@FirstName,@LastName,@Grade,@Student,@Librarian,@Admin)";
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + LbConnectionString.Text + ";Integrated Security=True");
            SqlCommand sqlcmd = new SqlCommand(query, sqlconn);
            SqlDataReader myReader;
            string Student = "1";
            string Librarian = "0";
            string Admin = "0";
            try
            {
                sqlconn.Open();
                // creates parameter and sets the value
                sqlcmd.Parameters.Add("@Username", txtUsername.Text);
                sqlcmd.Parameters.Add("@Password", txtPassword.Text);
                sqlcmd.Parameters.Add("@FirstName", txtFirstName.Text);
                sqlcmd.Parameters.Add("@LastName", txtLastName.Text);
                sqlcmd.Parameters.Add("@Grade", txtGrade.Text);
                sqlcmd.Parameters.Add("@Student", Student);
                sqlcmd.Parameters.Add("@Librarian", Librarian);
                sqlcmd.Parameters.Add("@Admin", Admin);
                myReader = sqlcmd.ExecuteReader();
                while (myReader.Read())
                {

                }
                sqlconn.Close();
                MessageBox.Show("Account Created!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin(LbConnectionString.Text);
            this.Close();
            frmLogin.Show();
        }
    }
}
