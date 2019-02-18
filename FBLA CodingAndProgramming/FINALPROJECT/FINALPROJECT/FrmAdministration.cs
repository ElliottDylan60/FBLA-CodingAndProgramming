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
    public partial class FrmAdministration : Form
    {
        public FrmAdministration(string ConnectionString)
        {
            InitializeComponent();
            LbConnectionString.Text = ConnectionString;
        }

        private void FrmAdministration_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'test5.BookAddedInfo' table. You can move, or remove it, as needed.
            this.bookAddedInfoTableAdapter.Fill(this.test5.BookAddedInfo);
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + LbConnectionString.Text + ";Integrated Security=True");
            string query = "Select * from StudentInformation";
            SqlCommand sqlcmd = new SqlCommand(query, sqlconn);
            try
            {
                sqlconn.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = sqlcmd;
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dtbl;
                studentInformationDataGridView.DataSource = bSource;
                dataGridView2.DataSource = bSource;
                sda.Update(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlconn.Close();
        }
        



        private void btnCreate_Click(object sender, EventArgs e)
        {
            string query = "Insert into StudentInformation (Username,Password,FirstName,LastName,Grade,Student,Librarian,Admin) Values (@Username,@Password,@FirstName,@LastName,@Grade,@Student,@Librarian,@Admin)";
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + LbConnectionString.Text + ";Integrated Security=True");
            SqlCommand sqlcmd = new SqlCommand(query, sqlconn);
            SqlDataReader myReader;
            string Student = "1";
            string Librarian = "0";
            string Admin = "0";

            if(StudentCheck.CheckState == CheckState.Checked)
            {
                Student = "1";
                Librarian = "0";
                Admin = "0";
            }
            else
            {
                if(LibrarianCheck.CheckState == CheckState.Checked)
                {
                    Student = "0";
                    Librarian = "1";
                    Admin = "0";
                }
                else
                {
                    if(AdministratorCheck.CheckState == CheckState.Checked)
                    {
                        Student = "0";
                        Librarian = "0";
                        Admin = "1";
                    }
                    
                }
            }
            
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
                MessageBox.Show("Account Created!");
                while (myReader.Read())
                {

                }
                sqlconn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // refresh datGridView after something was Added
            string refresh = "Select * from StudentInformation";
            SqlCommand RefreshCmd = new SqlCommand(refresh, sqlconn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = RefreshCmd;
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dtbl;
                studentInformationDataGridView.DataSource = bSource;
                dataGridView2.DataSource = bSource;
                sda.Update(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtGrade.Text = "";
            
        }

        private void StudentCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(StudentCheck.CheckState == CheckState.Checked)
            {
                txtGrade.ReadOnly = false;
                LibrarianCheck.CheckState = CheckState.Unchecked;
                AdministratorCheck.CheckState = CheckState.Unchecked;
            }
            else
            {
                StudentCheck.CheckState = CheckState.Unchecked;
            }
        }

        private void LibrarianCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(LibrarianCheck.CheckState == CheckState.Checked)
            {
                txtGrade.ReadOnly = true;
                StudentCheck.CheckState = CheckState.Unchecked;
                AdministratorCheck.CheckState = CheckState.Unchecked;

            }
            else
            {
                LibrarianCheck.CheckState = CheckState.Unchecked;
            }
        }

        private void AdministratorCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(AdministratorCheck.CheckState == CheckState.Checked)
            {
                txtGrade.ReadOnly = true;
                StudentCheck.CheckState = CheckState.Unchecked;
                LibrarianCheck.CheckState = CheckState.Unchecked;
            }
            else
            {
                AdministratorCheck.CheckState = CheckState.Unchecked;
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string query = "Insert into BookAddedInfo (ISBN,BookTitle,BookAuthor,Availably,RedemptionCode) Values (@ISBN,@BookTitle,@BookAuthor,@Availably,@RedemptionCode)";
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + LbConnectionString.Text + ";Integrated Security=True");
            SqlCommand sqlcmd = new SqlCommand(query, sqlconn);
            SqlDataReader myReader;
            try
            {
                sqlconn.Open();
                sqlcmd.Parameters.Add("@ISBN", txtISBN.Text);
                sqlcmd.Parameters.Add("@BookTitle", txtTitle.Text);
                sqlcmd.Parameters.Add("@BookAuthor", txtAuthor.Text);
                sqlcmd.Parameters.Add("@Availably", "1");
                sqlcmd.Parameters.Add("@RedemptionCode", txtRedemptionCode.Text);

                myReader = sqlcmd.ExecuteReader();
                MessageBox.Show("Book Added");
                while (myReader.Read())
                {

                }
                sqlconn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // refresh datGridView after something was added
            string refresh = "Select * from BookAddedInfo";
            SqlCommand RefreshCmd = new SqlCommand(refresh, sqlconn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = RefreshCmd;
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dtbl;
                bookAddedInfoDataGridView.DataSource = bSource;
                dataGridView1.DataSource = bSource;
                sda.Update(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtISBN.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtRedemptionCode.Text = "";
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            string query = "Delete From BookAddedInfo Where BookTitle = '"+txtBookTitle.Text.Trim()+"'";
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + LbConnectionString.Text + ";Integrated Security=True");
            SqlCommand sqlcmd = new SqlCommand(query, sqlconn);
            SqlDataReader myReader;
            try
            {
                sqlconn.Open();
                myReader = sqlcmd.ExecuteReader();
                MessageBox.Show("Book Deleted!");
                while (myReader.Read())
                {

                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // refresh datGridView after something was deleted
            string refresh = "Select * from BookAddedInfo";
            SqlCommand RefreshCmd = new SqlCommand(refresh, sqlconn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = RefreshCmd;
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dtbl;
                dataGridView1.DataSource = bSource;
                bookAddedInfoDataGridView.DataSource = bSource;
                sda.Update(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtBookTitle.Text = "";
        }

        private void btnRemoveAccount_Click(object sender, EventArgs e)
        {
            string query = "Delete From StudentInformation Where Username = '" + txtAccountUsername.Text + "'";
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + LbConnectionString.Text + ";Integrated Security=True");
            SqlCommand sqlcmd = new SqlCommand(query, sqlconn);
            SqlDataReader myReader;
            try
            {
                sqlconn.Open();
                myReader = sqlcmd.ExecuteReader();
                MessageBox.Show("Account Deleted!");
                while (myReader.Read())
                {

                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // refresh datGridView after something was deleted
            string refresh = "Select * from StudentInformation";
            SqlCommand RefreshCmd = new SqlCommand(refresh, sqlconn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = RefreshCmd;
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dtbl;
                dataGridView2.DataSource = bSource;
                studentInformationDataGridView.DataSource = bSource;
                sda.Update(dtbl);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtAccountUsername.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmLogin objFrmLogin = new FrmLogin(LbConnectionString.Text);
                this.Close();
                objFrmLogin.Show();
            }
            else
            {

            }
        }
    }
}
