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
    public partial class FrmMain : Form
    {
        public FrmMain(string Username, string Password, string FirstName, string LastName, string Grade, string ConnectionString)
        {
            InitializeComponent();
            LbUsername.Text = Username;
            LbPassword.Text = Password;
            LbConnectionString.Text = ConnectionString;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // this loads all the data from bookAddedInfo and doesnt't load books checked out
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + LbConnectionString.Text + ";Integrated Security=True");
            string RefreshQuerry = "Select BookTitle, BookAuthor From BookAddedInfo Where Availably = '1'";
            SqlCommand refreshcmd = new SqlCommand(RefreshQuerry, conn);
            try
            {
                SqlDataAdapter Refreshsda = new SqlDataAdapter();
                Refreshsda.SelectCommand = refreshcmd;
                DataTable dtbl = new DataTable();
                Refreshsda.Fill(dtbl);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dtbl;
                dataGridView1.DataSource = bSource;
                Refreshsda.Update(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // gets FirstName, lastName, and Grade from StudentInformation
            string query = "Select * From StudentInformation Where Username = '" + LbUsername.Text + "'";
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + LbConnectionString.Text + ";Integrated Security=True");
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand(query, sqlconn);
            SqlDataReader myReader = sqlcmd.ExecuteReader();
            if (myReader.Read())
            {
                txtFirstName.Text = (myReader["FirstName"].ToString());
                txtLastName.Text = (myReader["LastName"].ToString());
                txtGrade.Text = (myReader["Grade"].ToString());
            }
            sqlconn.Close();
            
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + LbConnectionString.Text + ";Integrated Security=True");
            // delets book if there was one checked out before
            try
            {
                string BookAddedInfo = "Update BookAddedInfo Set Availably = '1', CheckedOutBy = '', TimeCheckedOut = '' where CheckedOutBy = '" + LbUsername.Text+"'";
                SqlCommand Bookcmd = new SqlCommand(BookAddedInfo, sqlconn);
                SqlDataReader BookReader;
                
                    sqlconn.Open();
                    BookReader = Bookcmd.ExecuteReader();
                    while (BookReader.Read())
                    {

                    }
                    sqlconn.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                string StudentInformation = "Update StudentInformation Set BookTitle = '', CheckOutDate = '', DueDate = '' Where Username = '" + LbUsername.Text+"'";
                SqlCommand StudentCmd = new SqlCommand(StudentInformation, sqlconn);
                SqlDataReader StudentReader;
                try
                {
                    sqlconn.Open();
                    StudentReader = StudentCmd.ExecuteReader();
                    while (StudentReader.Read())
                    {

                    }
                    sqlconn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            
            //updates database to tell when a book was checked out
            string query = "Update BookAddedInfo Set TimeCheckedOut = '"+dateTimePicker1.Text+ "', Availably = '0', CheckedOutBy = '"+LbUsername.Text+"' Where BookTitle = '" + txtBookTitle.Text.Trim()+ "' and Availably = '1'";
            SqlCommand sqlcmd = new SqlCommand(query, sqlconn);
            
            SqlDataReader myReader;
            try
            {
                sqlconn.Open();
                myReader = sqlcmd.ExecuteReader();
                    
                while (myReader.Read())
                {
                    
                    
                }
                sqlconn.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //updates StudentInformation database with book title, dueDate, etc.
            try
            {
                string studentquery = "Update StudentInformation Set BookTitle = '" + txtBookTitle.Text + "', CheckOutDate = '" + dateTimePicker1.Text + "', DueDate = '" + dateTimePicker1.Value.AddDays(7).ToString() + "' Where Username = '"+LbUsername.Text+"'";
                SqlCommand sqlcmdV2 = new SqlCommand(studentquery,sqlconn);
                SqlDataReader Reader;
                sqlconn.Open();
                Reader = sqlcmdV2.ExecuteReader();
                while (Reader.Read())
                {

                }
                sqlconn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            // refreshes database AFTER database was updated
            string RefreshQuerry = "Select BookTitle, BookAuthor From BookAddedInfo Where Availably = '1'";
            SqlCommand refreshcmd = new SqlCommand(RefreshQuerry, sqlconn);
            try
            {
                SqlDataAdapter Refreshsda = new SqlDataAdapter(); 
                Refreshsda.SelectCommand = refreshcmd;
                DataTable dtbl = new DataTable();
                Refreshsda.Fill(dtbl);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dtbl;
                dataGridView1.DataSource = bSource;
                Refreshsda.Update(dtbl);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LbMyAccount_Click(object sender, EventArgs e)
        {
            
            FrmMyAccount FrmAccount = new FrmMyAccount(LbUsername.Text, LbPassword.Text, txtFirstName.Text, txtLastName.Text, txtGrade.Text, LbConnectionString.Text);
            this.Hide();
            FrmAccount.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmLogin frmLogin = new FrmLogin(LbConnectionString.Text);
                this.Close();
                frmLogin.Show();
            }
            else
            {

            }
            
            
        }


    }
}
