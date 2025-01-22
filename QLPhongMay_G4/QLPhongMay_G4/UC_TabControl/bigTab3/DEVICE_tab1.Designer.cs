namespace QLPhongMay_G4.UC_TabControl.bigTab3
{
    partial class DEVICE_tab1
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
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbDeviceType = new System.Windows.Forms.ComboBox();
            this.cbBigStatus = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbDeviceId = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbRoomId = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rdbStatus1 = new System.Windows.Forms.RadioButton();
            this.rdbStatus2 = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBoxTitle2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDeviceId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNameDevice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDeviceStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colErrorNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBuiding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxTitle1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBoxTitle2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTitle1
            // 
            this.groupBoxTitle1.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTitle1.Controls.Add(this.btnAddDevice);
            this.groupBoxTitle1.Controls.Add(this.groupBox5);
            this.groupBoxTitle1.Controls.Add(this.cbBigStatus);
            this.groupBoxTitle1.Controls.Add(this.groupBox3);
            this.groupBoxTitle1.Controls.Add(this.groupBox1);
            this.groupBoxTitle1.Controls.Add(this.groupBox2);
            this.groupBoxTitle1.Controls.Add(this.groupBox6);
            this.groupBoxTitle1.Controls.Add(this.btnFind);
            this.groupBoxTitle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTitle1.ForeColor = System.Drawing.Color.White;
            this.groupBoxTitle1.Location = new System.Drawing.Point(6, 6);
            this.groupBoxTitle1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxTitle1.Name = "groupBoxTitle1";
            this.groupBoxTitle1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxTitle1.Size = new System.Drawing.Size(1558, 207);
            this.groupBoxTitle1.TabIndex = 13;
            this.groupBoxTitle1.TabStop = false;
            this.groupBoxTitle1.Text = "Tra cứu thiết bị";
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.BackColor = System.Drawing.Color.Gray;
            this.btnAddDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDevice.FlatAppearance.BorderSize = 0;
            this.btnAddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDevice.ForeColor = System.Drawing.Color.White;
            this.btnAddDevice.Location = new System.Drawing.Point(551, 139);
            this.btnAddDevice.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(218, 40);
            this.btnAddDevice.TabIndex = 34;
            this.btnAddDevice.Text = "Thêm thiết bị";
            this.btnAddDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddDevice.UseVisualStyleBackColor = false;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbDeviceType);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(857, 35);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(143, 67);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Loại thiết bị";
            // 
            // cbDeviceType
            // 
            this.cbDeviceType.BackColor = System.Drawing.Color.White;
            this.cbDeviceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDeviceType.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cbDeviceType.ForeColor = System.Drawing.Color.Black;
            this.cbDeviceType.FormattingEnabled = true;
            this.cbDeviceType.Location = new System.Drawing.Point(9, 24);
            this.cbDeviceType.Margin = new System.Windows.Forms.Padding(6);
            this.cbDeviceType.MaxLength = 50;
            this.cbDeviceType.Name = "cbDeviceType";
            this.cbDeviceType.Size = new System.Drawing.Size(126, 33);
            this.cbDeviceType.TabIndex = 10;
            this.cbDeviceType.Validating += new System.ComponentModel.CancelEventHandler(this.cbDeviceType_Validating);
            // 
            // cbBigStatus
            // 
            this.cbBigStatus.AutoSize = true;
            this.cbBigStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBigStatus.Location = new System.Drawing.Point(1067, 33);
            this.cbBigStatus.Name = "cbBigStatus";
            this.cbBigStatus.Size = new System.Drawing.Size(89, 23);
            this.cbBigStatus.TabIndex = 3;
            this.cbBigStatus.Text = "Trạng thái";
            this.cbBigStatus.UseVisualStyleBackColor = true;
            this.cbBigStatus.CheckedChanged += new System.EventHandler(this.cbBigStatus_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbDeviceId);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(668, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 67);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Số thứ tự thiết bị";
            // 
            // cbDeviceId
            // 
            this.cbDeviceId.BackColor = System.Drawing.Color.White;
            this.cbDeviceId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDeviceId.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cbDeviceId.ForeColor = System.Drawing.Color.Black;
            this.cbDeviceId.FormattingEnabled = true;
            this.cbDeviceId.Location = new System.Drawing.Point(9, 24);
            this.cbDeviceId.Margin = new System.Windows.Forms.Padding(6);
            this.cbDeviceId.MaxLength = 3;
            this.cbDeviceId.Name = "cbDeviceId";
            this.cbDeviceId.Size = new System.Drawing.Size(126, 33);
            this.cbDeviceId.TabIndex = 10;
            this.cbDeviceId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbDeviceId_KeyPress);
            this.cbDeviceId.Validating += new System.ComponentModel.CancelEventHandler(this.cbDeviceId_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(290, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 67);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khu";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.DisplayMember = "KHU I";
            this.comboBox2.Enabled = false;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.comboBox2.ForeColor = System.Drawing.Color.Black;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(9, 22);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(126, 33);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Text = "KHU I";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbRoomId);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(480, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 67);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thuộc mã phòng";
            // 
            // cbRoomId
            // 
            this.cbRoomId.BackColor = System.Drawing.Color.White;
            this.cbRoomId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoomId.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cbRoomId.ForeColor = System.Drawing.Color.Black;
            this.cbRoomId.FormattingEnabled = true;
            this.cbRoomId.Location = new System.Drawing.Point(9, 24);
            this.cbRoomId.Margin = new System.Windows.Forms.Padding(6);
            this.cbRoomId.MaxLength = 5;
            this.cbRoomId.Name = "cbRoomId";
            this.cbRoomId.Size = new System.Drawing.Size(126, 33);
            this.cbRoomId.TabIndex = 4;
            this.cbRoomId.Validating += new System.ComponentModel.CancelEventHandler(this.cbRoomId_Validating);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rdbStatus1);
            this.groupBox6.Controls.Add(this.rdbStatus2);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(1050, 35);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(246, 67);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "                 ";
            // 
            // rdbStatus1
            // 
            this.rdbStatus1.AutoSize = true;
            this.rdbStatus1.Checked = true;
            this.rdbStatus1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.rdbStatus1.Location = new System.Drawing.Point(17, 25);
            this.rdbStatus1.Name = "rdbStatus1";
            this.rdbStatus1.Size = new System.Drawing.Size(119, 29);
            this.rdbStatus1.TabIndex = 0;
            this.rdbStatus1.TabStop = true;
            this.rdbStatus1.Text = "Hoạt đồng";
            this.rdbStatus1.UseVisualStyleBackColor = true;
            // 
            // rdbStatus2
            // 
            this.rdbStatus2.AutoSize = true;
            this.rdbStatus2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.rdbStatus2.Location = new System.Drawing.Point(153, 25);
            this.rdbStatus2.Name = "rdbStatus2";
            this.rdbStatus2.Size = new System.Drawing.Size(85, 29);
            this.rdbStatus2.TabIndex = 1;
            this.rdbStatus2.Text = "Bảo trì";
            this.rdbStatus2.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Gray;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(795, 139);
            this.btnFind.Margin = new System.Windows.Forms.Padding(6);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(218, 40);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // groupBoxTitle2
            // 
            this.groupBoxTitle2.Controls.Add(this.listView1);
            this.groupBoxTitle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTitle2.ForeColor = System.Drawing.Color.White;
            this.groupBoxTitle2.Location = new System.Drawing.Point(6, 240);
            this.groupBoxTitle2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxTitle2.Name = "groupBoxTitle2";
            this.groupBoxTitle2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxTitle2.Size = new System.Drawing.Size(1558, 580);
            this.groupBoxTitle2.TabIndex = 14;
            this.groupBoxTitle2.TabStop = false;
            this.groupBoxTitle2.Text = "Danh sách thiết bị";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.SlateGray;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colDeviceId,
            this.colNameDevice,
            this.colDeviceStatus,
            this.colErrorNote,
            this.colBuiding,
            this.colRoomId});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 35);
            this.listView1.Margin = new System.Windows.Forms.Padding(6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1534, 533);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            this.colSTT.Width = 67;
            // 
            // colDeviceId
            // 
            this.colDeviceId.Text = "Số thứ tự thiết bị";
            this.colDeviceId.Width = 262;
            // 
            // colNameDevice
            // 
            this.colNameDevice.Text = "Loại thiết bị";
            this.colNameDevice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNameDevice.Width = 135;
            // 
            // colDeviceStatus
            // 
            this.colDeviceStatus.Text = "Trạng thái";
            this.colDeviceStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDeviceStatus.Width = 206;
            // 
            // colErrorNote
            // 
            this.colErrorNote.Text = "Nội dung lỗi";
            this.colErrorNote.Width = 398;
            // 
            // colBuiding
            // 
            this.colBuiding.Text = "Khu";
            this.colBuiding.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBuiding.Width = 115;
            // 
            // colRoomId
            // 
            this.colRoomId.Text = "Phòng";
            this.colRoomId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colRoomId.Width = 160;
            // 
            // DEVICE_tab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBoxTitle1);
            this.Controls.Add(this.groupBoxTitle2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DEVICE_tab1";
            this.Size = new System.Drawing.Size(1570, 840);
            this.groupBoxTitle1.ResumeLayout(false);
            this.groupBoxTitle1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBoxTitle2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTitle1;
        private System.Windows.Forms.CheckBox cbBigStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbDeviceId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbRoomId;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rdbStatus1;
        private System.Windows.Forms.RadioButton rdbStatus2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox groupBoxTitle2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colBuiding;
        private System.Windows.Forms.ColumnHeader colRoomId;
        private System.Windows.Forms.ColumnHeader colDeviceId;
        private System.Windows.Forms.ColumnHeader colNameDevice;
        private System.Windows.Forms.ColumnHeader colDeviceStatus;
        private System.Windows.Forms.ColumnHeader colErrorNote;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbDeviceType;
        private System.Windows.Forms.Button btnAddDevice;
    }
}
