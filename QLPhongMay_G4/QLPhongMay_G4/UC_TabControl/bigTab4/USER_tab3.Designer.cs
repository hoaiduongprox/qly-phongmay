namespace QLPhongMay_G4.UC_TabControl.bigTab4
{
    partial class USER_tab3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxTitle1 = new System.Windows.Forms.GroupBox();
            this.groupBoxTitle2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbUserRole = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBoxTitle1.SuspendLayout();
            this.groupBoxTitle2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTitle1
            // 
            this.groupBoxTitle1.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTitle1.Controls.Add(this.groupBoxTitle2);
            this.groupBoxTitle1.Controls.Add(this.groupBox2);
            this.groupBoxTitle1.Controls.Add(this.groupBox4);
            this.groupBoxTitle1.Controls.Add(this.btnFind);
            this.groupBoxTitle1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.groupBoxTitle1.ForeColor = System.Drawing.Color.White;
            this.groupBoxTitle1.Location = new System.Drawing.Point(256, 6);
            this.groupBoxTitle1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxTitle1.Name = "groupBoxTitle1";
            this.groupBoxTitle1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxTitle1.Size = new System.Drawing.Size(1059, 660);
            this.groupBoxTitle1.TabIndex = 14;
            this.groupBoxTitle1.TabStop = false;
            this.groupBoxTitle1.Text = "Tra cứu tài khoản";
            // 
            // groupBoxTitle2
            // 
            this.groupBoxTitle2.Controls.Add(this.listView1);
            this.groupBoxTitle2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.groupBoxTitle2.ForeColor = System.Drawing.Color.White;
            this.groupBoxTitle2.Location = new System.Drawing.Point(488, 93);
            this.groupBoxTitle2.Name = "groupBoxTitle2";
            this.groupBoxTitle2.Size = new System.Drawing.Size(518, 469);
            this.groupBoxTitle2.TabIndex = 37;
            this.groupBoxTitle2.TabStop = false;
            this.groupBoxTitle2.Text = "Danh sách tài khoản";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUserId,
            this.colFullName,
            this.colEmail,
            this.colRole,
            this.colStatus});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(477, 417);
            this.listView1.TabIndex = 36;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // colUserId
            // 
            this.colUserId.Text = "MSSV, MSCB";
            this.colUserId.Width = 149;
            // 
            // colFullName
            // 
            this.colFullName.Text = "Họ và tên";
            this.colFullName.Width = 125;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.Width = 125;
            // 
            // colRole
            // 
            this.colRole.Text = "Chức vụ";
            this.colRole.Width = 115;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Trạng thái";
            this.colStatus.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbUserRole);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(249, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 67);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức vụ";
            // 
            // cbUserRole
            // 
            this.cbUserRole.BackColor = System.Drawing.Color.White;
            this.cbUserRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUserRole.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cbUserRole.ForeColor = System.Drawing.Color.Black;
            this.cbUserRole.FormattingEnabled = true;
            this.cbUserRole.Location = new System.Drawing.Point(8, 22);
            this.cbUserRole.Margin = new System.Windows.Forms.Padding(6);
            this.cbUserRole.MaxLength = 50;
            this.cbUserRole.Name = "cbUserRole";
            this.cbUserRole.Size = new System.Drawing.Size(158, 33);
            this.cbUserRole.TabIndex = 11;
            this.cbUserRole.Validating += new System.ComponentModel.CancelEventHandler(this.cbUserRole_Validating);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbUserId);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(57, 221);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(176, 67);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MSSV hoặc MSCB";
            // 
            // tbUserId
            // 
            this.tbUserId.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbUserId.Location = new System.Drawing.Point(8, 23);
            this.tbUserId.MaxLength = 7;
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(158, 32);
            this.tbUserId.TabIndex = 22;
            this.tbUserId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUserId_KeyPress);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Gray;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(138, 319);
            this.btnFind.Margin = new System.Windows.Forms.Padding(6);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(218, 40);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Tìm tài khoản";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // USER_tab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBoxTitle1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "USER_tab3";
            this.Size = new System.Drawing.Size(1570, 840);
            this.groupBoxTitle1.ResumeLayout(false);
            this.groupBoxTitle2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTitle1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbUserRole;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox groupBoxTitle2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colUserId;
        private System.Windows.Forms.ColumnHeader colFullName;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colRole;
        private System.Windows.Forms.ColumnHeader colStatus;
    }
}
