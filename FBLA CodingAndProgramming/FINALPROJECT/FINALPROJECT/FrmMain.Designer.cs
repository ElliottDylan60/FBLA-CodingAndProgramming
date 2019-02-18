namespace FINALPROJECT
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.test4 = new FINALPROJECT.test4();
            this.bookValueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookValueTableAdapter = new FINALPROJECT.test4TableAdapters.BookValueTableAdapter();
            this.tableAdapterManager = new FINALPROJECT.test4TableAdapters.TableAdapterManager();
            this.bookValueBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bookValueBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.LbUsername = new System.Windows.Forms.Label();
            this.LbMyAccount = new System.Windows.Forms.Label();
            this.LbPassword = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.Label();
            this.test5 = new FINALPROJECT.test5();
            this.bookAddedInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookAddedInfoTableAdapter = new FINALPROJECT.test5TableAdapters.BookAddedInfoTableAdapter();
            this.tableAdapterManager1 = new FINALPROJECT.test5TableAdapters.TableAdapterManager();
            this.bookAddedInfo = new FINALPROJECT.BookAddedInfo();
            this.bookAddedInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookAddedInfoTableAdapter1 = new FINALPROJECT.BookAddedInfoTableAdapters.BookAddedInfoTableAdapter();
            this.tableAdapterManager2 = new FINALPROJECT.BookAddedInfoTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookCheckOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookDueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redemptionCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LbRedemptionCode = new System.Windows.Forms.Label();
            this.LbConnectionString = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.test4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookValueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookValueBindingNavigator)).BeginInit();
            this.bookValueBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookAddedInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookAddedInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookAddedInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // test4
            // 
            this.test4.DataSetName = "test4";
            this.test4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookValueBindingSource
            // 
            this.bookValueBindingSource.DataMember = "BookValue";
            this.bookValueBindingSource.DataSource = this.test4;
            // 
            // bookValueTableAdapter
            // 
            this.bookValueTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = FINALPROJECT.test4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookValueBindingNavigator
            // 
            this.bookValueBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bookValueBindingNavigator.BindingSource = this.bookValueBindingSource;
            this.bookValueBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bookValueBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bookValueBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bookValueBindingNavigatorSaveItem});
            this.bookValueBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bookValueBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bookValueBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bookValueBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bookValueBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bookValueBindingNavigator.Name = "bookValueBindingNavigator";
            this.bookValueBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bookValueBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.bookValueBindingNavigator.TabIndex = 0;
            this.bookValueBindingNavigator.Text = "bindingNavigator1";
            this.bookValueBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bookValueBindingNavigatorSaveItem
            // 
            this.bookValueBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookValueBindingNavigatorSaveItem.Enabled = false;
            this.bookValueBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookValueBindingNavigatorSaveItem.Image")));
            this.bookValueBindingNavigatorSaveItem.Name = "bookValueBindingNavigatorSaveItem";
            this.bookValueBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bookValueBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCheckout);
            this.groupBox1.Controls.Add(this.txtBookTitle);
            this.groupBox1.Location = new System.Drawing.Point(12, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check Out";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date of Checkout";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Title";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(112, 74);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(6, 77);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(100, 20);
            this.txtBookTitle.TabIndex = 0;
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.Location = new System.Drawing.Point(664, 299);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(79, 13);
            this.LbUsername.TabIndex = 5;
            this.LbUsername.Text = "Username Text";
            this.LbUsername.Visible = false;
            // 
            // LbMyAccount
            // 
            this.LbMyAccount.AutoSize = true;
            this.LbMyAccount.Location = new System.Drawing.Point(732, 33);
            this.LbMyAccount.Name = "LbMyAccount";
            this.LbMyAccount.Size = new System.Drawing.Size(64, 13);
            this.LbMyAccount.TabIndex = 6;
            this.LbMyAccount.Text = "My Account";
            this.LbMyAccount.Click += new System.EventHandler(this.LbMyAccount_Click);
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Location = new System.Drawing.Point(664, 320);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(77, 13);
            this.LbPassword.TabIndex = 7;
            this.LbPassword.Text = "Password Text";
            this.LbPassword.Visible = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.AutoSize = true;
            this.txtFirstName.Location = new System.Drawing.Point(664, 338);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(54, 13);
            this.txtFirstName.TabIndex = 8;
            this.txtFirstName.Text = "FirstName";
            this.txtFirstName.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.AutoSize = true;
            this.txtLastName.Location = new System.Drawing.Point(664, 361);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(55, 13);
            this.txtLastName.TabIndex = 9;
            this.txtLastName.Text = "LastName";
            this.txtLastName.Visible = false;
            // 
            // txtGrade
            // 
            this.txtGrade.AutoSize = true;
            this.txtGrade.Location = new System.Drawing.Point(664, 383);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(36, 13);
            this.txtGrade.TabIndex = 10;
            this.txtGrade.Text = "Grade";
            this.txtGrade.Visible = false;
            // 
            // test5
            // 
            this.test5.DataSetName = "test5";
            this.test5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookAddedInfoBindingSource
            // 
            this.bookAddedInfoBindingSource.DataMember = "BookAddedInfo";
            this.bookAddedInfoBindingSource.DataSource = this.test5;
            // 
            // bookAddedInfoTableAdapter
            // 
            this.bookAddedInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BookAddedInfoTableAdapter = this.bookAddedInfoTableAdapter;
            this.tableAdapterManager1.UpdateOrder = FINALPROJECT.test5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookAddedInfo
            // 
            this.bookAddedInfo.DataSetName = "BookAddedInfo";
            this.bookAddedInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookAddedInfoBindingSource1
            // 
            this.bookAddedInfoBindingSource1.DataMember = "BookAddedInfo";
            this.bookAddedInfoBindingSource1.DataSource = this.bookAddedInfo;
            // 
            // bookAddedInfoTableAdapter1
            // 
            this.bookAddedInfoTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = FINALPROJECT.BookAddedInfoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(721, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 169);
            this.dataGridView1.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookCheckOutToolStripMenuItem,
            this.bookReturnToolStripMenuItem,
            this.bookDueToolStripMenuItem,
            this.redemptionCodeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // bookCheckOutToolStripMenuItem
            // 
            this.bookCheckOutToolStripMenuItem.Name = "bookCheckOutToolStripMenuItem";
            this.bookCheckOutToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.bookCheckOutToolStripMenuItem.Text = "Book CheckOut";
            // 
            // bookReturnToolStripMenuItem
            // 
            this.bookReturnToolStripMenuItem.Name = "bookReturnToolStripMenuItem";
            this.bookReturnToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.bookReturnToolStripMenuItem.Text = "Book Return";
            // 
            // bookDueToolStripMenuItem
            // 
            this.bookDueToolStripMenuItem.Name = "bookDueToolStripMenuItem";
            this.bookDueToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.bookDueToolStripMenuItem.Text = "Book Due";
            // 
            // redemptionCodeToolStripMenuItem
            // 
            this.redemptionCodeToolStripMenuItem.Name = "redemptionCodeToolStripMenuItem";
            this.redemptionCodeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.redemptionCodeToolStripMenuItem.Text = "Redemption Code";
            // 
            // LbRedemptionCode
            // 
            this.LbRedemptionCode.AutoSize = true;
            this.LbRedemptionCode.Location = new System.Drawing.Point(476, 275);
            this.LbRedemptionCode.Name = "LbRedemptionCode";
            this.LbRedemptionCode.Size = new System.Drawing.Size(89, 13);
            this.LbRedemptionCode.TabIndex = 14;
            this.LbRedemptionCode.Text = "RedemptionCode";
            // 
            // LbConnectionString
            // 
            this.LbConnectionString.AutoSize = true;
            this.LbConnectionString.Location = new System.Drawing.Point(479, 299);
            this.LbConnectionString.Name = "LbConnectionString";
            this.LbConnectionString.Size = new System.Drawing.Size(88, 13);
            this.LbConnectionString.TabIndex = 15;
            this.LbConnectionString.Text = "ConnectionString";
            this.LbConnectionString.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.LbConnectionString);
            this.Controls.Add(this.LbRedemptionCode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.LbMyAccount);
            this.Controls.Add(this.LbUsername);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bookValueBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qu";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.test4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookValueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookValueBindingNavigator)).EndInit();
            this.bookValueBindingNavigator.ResumeLayout(false);
            this.bookValueBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookAddedInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookAddedInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookAddedInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private test4 test4;
        private System.Windows.Forms.BindingSource bookValueBindingSource;
        private test4TableAdapters.BookValueTableAdapter bookValueTableAdapter;
        private test4TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bookValueBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bookValueBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.Label LbMyAccount;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.Label txtFirstName;
        private System.Windows.Forms.Label txtLastName;
        private System.Windows.Forms.Label txtGrade;
        private test5 test5;
        private System.Windows.Forms.BindingSource bookAddedInfoBindingSource;
        private test5TableAdapters.BookAddedInfoTableAdapter bookAddedInfoTableAdapter;
        private test5TableAdapters.TableAdapterManager tableAdapterManager1;
        private BookAddedInfo bookAddedInfo;
        private System.Windows.Forms.BindingSource bookAddedInfoBindingSource1;
        private BookAddedInfoTableAdapters.BookAddedInfoTableAdapter bookAddedInfoTableAdapter1;
        private BookAddedInfoTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookCheckOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookDueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redemptionCodeToolStripMenuItem;
        private System.Windows.Forms.Label LbRedemptionCode;
        private System.Windows.Forms.Label LbConnectionString;
    }
}