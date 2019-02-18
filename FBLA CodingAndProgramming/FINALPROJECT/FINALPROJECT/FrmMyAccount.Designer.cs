namespace FINALPROJECT
{
    partial class FrmMyAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMyAccount));
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtReturn = new System.Windows.Forms.TextBox();
            this.GetGrade = new System.Windows.Forms.Label();
            this.GetLastName = new System.Windows.Forms.Label();
            this.GetFirstName = new System.Windows.Forms.Label();
            this.LbBooks = new System.Windows.Forms.Label();
            this.LbGrade = new System.Windows.Forms.Label();
            this.LbLastName = new System.Windows.Forms.Label();
            this.LbFirstName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GetUsername = new System.Windows.Forms.Label();
            this.GetPassword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.LbConnectionString = new System.Windows.Forms.Label();
            this.TabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage3);
            this.TabControl1.Location = new System.Drawing.Point(-1, 63);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(803, 387);
            this.TabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.GetGrade);
            this.tabPage3.Controls.Add(this.GetLastName);
            this.tabPage3.Controls.Add(this.GetFirstName);
            this.tabPage3.Controls.Add(this.LbBooks);
            this.tabPage3.Controls.Add(this.LbGrade);
            this.tabPage3.Controls.Add(this.LbLastName);
            this.tabPage3.Controls.Add(this.LbFirstName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(795, 361);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Information";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(9, 151);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(306, 101);
            this.dataGridView3.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnReturn);
            this.groupBox1.Controls.Add(this.txtReturn);
            this.groupBox1.Location = new System.Drawing.Point(12, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Return Book";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date of Return";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Title";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(112, 72);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtReturn
            // 
            this.txtReturn.Location = new System.Drawing.Point(6, 74);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.Size = new System.Drawing.Size(100, 20);
            this.txtReturn.TabIndex = 0;
            // 
            // GetGrade
            // 
            this.GetGrade.AutoSize = true;
            this.GetGrade.Location = new System.Drawing.Point(54, 92);
            this.GetGrade.Name = "GetGrade";
            this.GetGrade.Size = new System.Drawing.Size(36, 13);
            this.GetGrade.TabIndex = 6;
            this.GetGrade.Text = "Grade";
            // 
            // GetLastName
            // 
            this.GetLastName.AutoSize = true;
            this.GetLastName.Location = new System.Drawing.Point(76, 58);
            this.GetLastName.Name = "GetLastName";
            this.GetLastName.Size = new System.Drawing.Size(58, 13);
            this.GetLastName.TabIndex = 5;
            this.GetLastName.Text = "Last Name";
            // 
            // GetFirstName
            // 
            this.GetFirstName.AutoSize = true;
            this.GetFirstName.Location = new System.Drawing.Point(75, 29);
            this.GetFirstName.Name = "GetFirstName";
            this.GetFirstName.Size = new System.Drawing.Size(57, 13);
            this.GetFirstName.TabIndex = 4;
            this.GetFirstName.Text = "First Name";
            // 
            // LbBooks
            // 
            this.LbBooks.AutoSize = true;
            this.LbBooks.Location = new System.Drawing.Point(9, 124);
            this.LbBooks.Name = "LbBooks";
            this.LbBooks.Size = new System.Drawing.Size(106, 13);
            this.LbBooks.TabIndex = 3;
            this.LbBooks.Text = "Books Checked Out:";
            // 
            // LbGrade
            // 
            this.LbGrade.AutoSize = true;
            this.LbGrade.Location = new System.Drawing.Point(9, 92);
            this.LbGrade.Name = "LbGrade";
            this.LbGrade.Size = new System.Drawing.Size(39, 13);
            this.LbGrade.TabIndex = 2;
            this.LbGrade.Text = "Grade:";
            // 
            // LbLastName
            // 
            this.LbLastName.AutoSize = true;
            this.LbLastName.Location = new System.Drawing.Point(9, 58);
            this.LbLastName.Name = "LbLastName";
            this.LbLastName.Size = new System.Drawing.Size(61, 13);
            this.LbLastName.TabIndex = 1;
            this.LbLastName.Text = "Last Name:";
            // 
            // LbFirstName
            // 
            this.LbFirstName.AutoSize = true;
            this.LbFirstName.Location = new System.Drawing.Point(9, 29);
            this.LbFirstName.Name = "LbFirstName";
            this.LbFirstName.Size = new System.Drawing.Size(60, 13);
            this.LbFirstName.TabIndex = 0;
            this.LbFirstName.Text = "First Name:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Return";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // GetUsername
            // 
            this.GetUsername.AutoSize = true;
            this.GetUsername.Location = new System.Drawing.Point(165, 12);
            this.GetUsername.Name = "GetUsername";
            this.GetUsername.Size = new System.Drawing.Size(55, 13);
            this.GetUsername.TabIndex = 5;
            this.GetUsername.Text = "Username";
            // 
            // GetPassword
            // 
            this.GetPassword.AutoSize = true;
            this.GetPassword.Location = new System.Drawing.Point(165, 47);
            this.GetPassword.Name = "GetPassword";
            this.GetPassword.Size = new System.Drawing.Size(48, 13);
            this.GetPassword.TabIndex = 6;
            this.GetPassword.Text = "Pasword";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // LbConnectionString
            // 
            this.LbConnectionString.AutoSize = true;
            this.LbConnectionString.Location = new System.Drawing.Point(366, 46);
            this.LbConnectionString.Name = "LbConnectionString";
            this.LbConnectionString.Size = new System.Drawing.Size(91, 13);
            this.LbConnectionString.TabIndex = 8;
            this.LbConnectionString.Text = "Connection String";
            // 
            // FrmMyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbConnectionString);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GetPassword);
            this.Controls.Add(this.GetUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.TabControl1);
            this.Name = "FrmMyAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Settings";
            this.Load += new System.EventHandler(this.FrmMyAccount_Load);
            this.TabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtReturn;
        private System.Windows.Forms.Label GetGrade;
        private System.Windows.Forms.Label GetLastName;
        private System.Windows.Forms.Label GetFirstName;
        private System.Windows.Forms.Label LbBooks;
        private System.Windows.Forms.Label LbGrade;
        private System.Windows.Forms.Label LbLastName;
        private System.Windows.Forms.Label LbFirstName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label GetUsername;
        private System.Windows.Forms.Label GetPassword;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label LbConnectionString;
    }
}