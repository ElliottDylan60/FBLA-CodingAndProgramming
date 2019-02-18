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
    public partial class FrmMyAccount : Form
    {
        public FrmMyAccount(string Username, string Password, string FirstName, string LastName, string Grade, string ConnectionString)
        {
            InitializeComponent();
            GetUsername.Text = Username;
            GetPassword.Text = Password;
            GetFirstName.Text = FirstName;
            GetLastName.Text = LastName;
            GetGrade.Text = Grade;
            LbConnectionString.Text = ConnectionString;
        }
        private void FrmMyAccount_Load(object sender, EventArgs e)
        {
            // creates data for dataGridView
            string query = "Select BookTitle, CheckOutDate, DueDate from StudentInformation where Username = '" + GetUsername.Text + "'";
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + LbConnectionString.Text + ";Integrated Security=True");
            SqlCommand sqlcmd = new SqlCommand(query, sqlconn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = sqlcmd;
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dtbl;
                dataGridView3.DataSource = bSource;
                sda.Update(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain objFrmMain = new FrmMain(GetUsername.Text, GetPassword.Text, LbFirstName.Text, LbLastName.Text, LbGrade.Text, LbConnectionString.Text);
            this.Close();
            objFrmMain.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            
            
                SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + LbConnectionString.Text + ";Integrated Security=True");
            // updates BookAddedInfo database
            try
            {
                string query2 = "Update BookAddedInfo Set Availably = '1', CheckedOutBy = '', TimeCheckedOut = '' where BookTitle = '" + txtReturn.Text + "'";
                SqlCommand sqlcmd2 = new SqlCommand(query2, sqlconn);
                SqlDataReader Reader2;
                sqlconn.Open();
                Reader2 = sqlcmd2.ExecuteReader();
                while (Reader2.Read())
                {

                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // updates StudentInformation database
            try
            {
                string query = "Update StudentInformation Set BookTitle = '',CheckOutDate = '', DueDate = '' where Username = '" + GetUsername.Text + "'";
                SqlCommand sqlcmd = new SqlCommand(query, sqlconn);
                SqlDataReader Reader;
                sqlconn.Open();
                Reader = sqlcmd.ExecuteReader();
                while (Reader.Read())
                {

                }
                sqlconn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // update database to show current data
            string RefreshQuerry = "Select BookTitle, CheckOutDate, DueDate from StudentInformation where Username = '"+GetUsername.Text+"'";
            SqlCommand refreshcmd = new SqlCommand(RefreshQuerry, sqlconn);
            try
            {
                SqlDataAdapter Refreshsda = new SqlDataAdapter();
                Refreshsda.SelectCommand = refreshcmd;
                DataTable dtbl = new DataTable();
                Refreshsda.Fill(dtbl);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dtbl;
                dataGridView3.DataSource = bSource;
                Refreshsda.Update(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
        
    }
}
