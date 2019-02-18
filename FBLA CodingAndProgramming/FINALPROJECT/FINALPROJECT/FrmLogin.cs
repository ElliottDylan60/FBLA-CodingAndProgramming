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
    public partial class FrmLogin : Form
    {

        // string used to check sign in options
        public string Student = "1";
        public string Librarian = "0";
        public string Administrator = "0";
        public string Frm = "FrmMain";
        // variables carried out through each form
        string FirstName;
        string LastName;
        string grade;


        public FrmLogin(string ConnectionString)
        {
            InitializeComponent();

            LbConnectionString.Text = ConnectionString;
            // Frm name for each account sign in option
            FrmAdministration FrmAdmin = new FrmAdministration(LbConnectionString.Text);
            FrmLibrarian FrmLibrarian = new FrmLibrarian(LbConnectionString.Text);
            FrmMain FrmMain = new FrmMain(txtUsername.Text, txtPassword.Text, FirstName, LastName, grade, LbConnectionString.Text);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            switch (ComboBoxSignIn.Text)
            {
                case "Student":
                    Student = "1";
                    Librarian = "0";
                    Administrator = "0";
                    Frm = "FrmMain";
                    break;
                case "Librarian":
                    Student = "0";
                    Librarian = "1";
                    Administrator = "0";
                    Frm = "FrmLibrarian";
                    break;
                case "Administrator":
                    Student = "0";
                    Librarian = "0";
                    Administrator = "1";
                    Frm = "Administrator";
                    break;
            }
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+LbConnectionString.Text+";Integrated Security=True");
            string query = "Select * from StudentInformation " +
                "where Username = '" + txtUsername.Text.Trim() + "' and " +
                "Password = '" + txtPassword.Text.Trim() + "'and " +
                "Student = '"+Student+"' and " +
                "Librarian = '"+ Librarian + "' and " +
                "Admin = '"+ Administrator + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query,sqlconn);
            DataTable dtbl = new DataTable();
            sqlconn.Open();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                switch (Frm)
                {
                    case "FrmMain":
                        FrmMain objFrmMain = new FrmMain(txtUsername.Text, txtPassword.Text, FirstName, LastName, grade, LbConnectionString.Text);
                        this.Hide();
                        objFrmMain.Show();
                        break;
                    case "FrmLibrarian":
                        FrmLibrarian FrmLibrarian = new FrmLibrarian(LbConnectionString.Text);
                        this.Hide();
                        FrmLibrarian.Show();
                        break;
                    case "Administrator":
                        FrmAdministration FrmAdmin = new FrmAdministration(LbConnectionString.Text);
                        this.Hide();
                        FrmAdmin.Show();
                        break;
                }

                
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
            sqlconn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LbCreateAccount_Click(object sender, EventArgs e)
        {
            FrmCreateAccount FrmCreate = new FrmCreateAccount(LbConnectionString.Text);
            this.Hide();
            FrmCreate.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SetupDatabase frmSetup = new SetupDatabase();
            this.Hide();
            frmSetup.Show();
        }
    }
}
