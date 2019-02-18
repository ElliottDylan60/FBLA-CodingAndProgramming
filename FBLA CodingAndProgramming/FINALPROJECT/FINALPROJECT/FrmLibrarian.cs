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
    public partial class FrmLibrarian : Form
    {
        public FrmLibrarian(string ConnectionString)
        {
            InitializeComponent();
            LbConnectionString.Text = ConnectionString;
        }

        private void FrmLibrarian_Load(object sender, EventArgs e)
        {
            string BookQuery = "Select * from BookAddedInfo";
            string StudentInfo = "Select * from StudentInformation";
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + LbConnectionString.Text + ";Integrated Security=True");

            //shows book info in DataGridView
            SqlCommand Bookcmd = new SqlCommand(BookQuery, sqlconn);
            try
            {
                SqlDataAdapter Refreshsda = new SqlDataAdapter();
                Refreshsda.SelectCommand = Bookcmd;
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
            //shows student info in dataGridView
            
            SqlCommand studentcmd = new SqlCommand(StudentInfo, sqlconn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = studentcmd;
                DataTable dtbl2 = new DataTable();
                sda.Fill(dtbl2);
                BindingSource bSource2 = new BindingSource();

                bSource2.DataSource = dtbl2;
                dataGridView2.DataSource = bSource2;
                sda.Update(dtbl2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            catch (Exception ex)
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
                dataGridView1.DataSource = bSource;
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
            // updates studentinformation database
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + LbConnectionString.Text + ";Integrated Security=True");
            try
            {
                string query2 = "Update StudentInformation Set BookTitle = '', CheckOutDate = '', DueDate = '' where BookTitle = '" + txtBookTitle.Text+"' and Username = '"+ txtUsername.Text+ "'";
                SqlCommand sqlcmd2 = new SqlCommand(query2, sqlconn);
                SqlDataReader Reader2;
                sqlconn.Open();
                Reader2 = sqlcmd2.ExecuteReader();
                MessageBox.Show("Book Removed!");
                while (Reader2.Read())
                {

                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //updates Bookinfo database
            try
            {
                string query3 = "Update BookAddedInfo Set Availably = '1', CheckedOutBy = '', TimeCheckedOut = '' where CheckedOutBy = '"+txtUsername.Text+"'";
                SqlCommand sqlcmd3 = new SqlCommand(query3, sqlconn);
                SqlDataReader Reader3;
                sqlconn.Open();
                Reader3 = sqlcmd3.ExecuteReader();
                while (Reader3.Read())
                {

                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // refreshes dataGridView with updated information
            string BookQuery = "Select * from StudentInformation";
            SqlCommand studentcmd = new SqlCommand(BookQuery, sqlconn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = studentcmd;
                DataTable dtbl2 = new DataTable();
                sda.Fill(dtbl2);
                BindingSource bSource2 = new BindingSource();

                bSource2.DataSource = dtbl2;
                dataGridView2.DataSource = bSource2;
                sda.Update(dtbl2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtBookTitle.Text = "";
            txtUsername.Text = "";

        }

        private void btnLogOut_Click(object sender, EventArgs e)
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
