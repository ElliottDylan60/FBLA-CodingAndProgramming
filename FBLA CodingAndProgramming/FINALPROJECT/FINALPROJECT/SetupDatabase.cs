using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALPROJECT
{
    public partial class SetupDatabase : Form
    {
        public SetupDatabase()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            label1.Text = txtConnectionString.Text;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FrmLogin frmlogin = new FrmLogin(label1.Text);
            this.Close();
            frmlogin.Show();
        }
    }
}
