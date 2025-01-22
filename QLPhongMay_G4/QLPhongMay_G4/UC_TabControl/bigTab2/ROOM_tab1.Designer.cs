namespace QLPhongMay_G4.UC_TabControl.bigTab2
{
    partial class ROOM_tab1
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
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.cbBigStatus = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbRoomCapacity = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbRoomId = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbStatus1 = new System.Windows.Forms.RadioButton();
            this.rdbStatus3 = new System.Windows.Forms.RadioButton();
            this.rdbStatus2 = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBoxTitle2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBuiding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomDevice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomCapacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colErrorNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxTitle1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxTitle2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTitle1
            // 
            this.groupBoxTitle1.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTitle1.Controls.Add(this.btnAddRoom);
            this.groupBoxTitle1.Controls.Add(this.cbBigStatus);
            this.groupBoxTitle1.Controls.Add(this.groupBox3);
            this.groupBoxTitle1.Controls.Add(this.groupBox1);
            this.groupBoxTitle1.Controls.Add(this.groupBox2);
            this.groupBoxTitle1.Controls.Add(this.groupBox4);
            this.groupBoxTitle1.Controls.Add(this.btnFind);
            this.groupBoxTitle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTitle1.ForeColor = System.Drawing.Color.White;
            this.groupBoxTitle1.Location = new System.Drawing.Point(6, 6);
            this.groupBoxTitle1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxTitle1.Name = "groupBoxTitle1";
            this.groupBoxTitle1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxTitle1.Size = new System.Drawing.Size(1558, 207);
            this.groupBoxTitle1.TabIndex = 11;
            this.groupBoxTitle1.TabStop = false;
            this.groupBoxTitle1.Text = "Tra cứu phòng";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.Gray;
            this.btnAddRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.FlatAppearance.BorderSize = 0;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(551, 140);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(218, 40);
            this.btnAddRoom.TabIndex = 33;
            this.btnAddRoom.Text = "Thêm phòng";
            this.btnAddRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // cbBigStatus
            // 
            this.cbBigStatus.AutoSize = true;
            this.cbBigStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBigStatus.Location = new System.Drawing.Point(922, 33);
            this.cbBigStatus.Name = "cbBigStatus";
            this.cbBigStatus.Size = new System.Drawing.Size(89, 23);
            this.cbBigStatus.TabIndex = 3;
            this.cbBigStatus.Text = "Trạng thái";
            this.cbBigStatus.UseVisualStyleBackColor = true;
            this.cbBigStatus.CheckedChanged += new System.EventHandler(this.cbBigStatus_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbRoomCapacity);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(721, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 67);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sức chứa";
            // 
            // cbRoomCapacity
            // 
            this.cbRoomCapacity.BackColor = System.Drawing.Color.White;
            this.cbRoomCapacity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoomCapacity.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cbRoomCapacity.ForeColor = System.Drawing.Color.Black;
            this.cbRoomCapacity.FormattingEnabled = true;
            this.cbRoomCapacity.Location = new System.Drawing.Point(9, 24);
            this.cbRoomCapacity.Margin = new System.Windows.Forms.Padding(6);
            this.cbRoomCapacity.MaxLength = 3;
            this.cbRoomCapacity.Name = "cbRoomCapacity";
            this.cbRoomCapacity.Size = new System.Drawing.Size(126, 33);
            this.cbRoomCapacity.TabIndex = 10;
            this.cbRoomCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbRoomCapacity_KeyPress);
            this.cbRoomCapacity.Validating += new System.ComponentModel.CancelEventHandler(this.cbRoomCapacity_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(343, 35);
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
            this.groupBox2.Location = new System.Drawing.Point(533, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 67);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã phòng";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbStatus1);
            this.groupBox4.Controls.Add(this.rdbStatus3);
            this.groupBox4.Controls.Add(this.rdbStatus2);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(905, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(404, 67);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "                    ";
            // 
            // rdbStatus1
            // 
            this.rdbStatus1.AutoSize = true;
            this.rdbStatus1.Checked = true;
            this.rdbStatus1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.rdbStatus1.Location = new System.Drawing.Point(17, 25);
            this.rdbStatus1.Name = "rdbStatus1";
            this.rdbStatus1.Size = new System.Drawing.Size(78, 29);
            this.rdbStatus1.TabIndex = 0;
            this.rdbStatus1.TabStop = true;
            this.rdbStatus1.Text = "Trống";
            this.rdbStatus1.UseVisualStyleBackColor = true;
            // 
            // rdbStatus3
            // 
            this.rdbStatus3.AutoSize = true;
            this.rdbStatus3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.rdbStatus3.Location = new System.Drawing.Point(305, 25);
            this.rdbStatus3.Name = "rdbStatus3";
            this.rdbStatus3.Size = new System.Drawing.Size(85, 29);
            this.rdbStatus3.TabIndex = 2;
            this.rdbStatus3.Text = "Bảo trì";
            this.rdbStatus3.UseVisualStyleBackColor = true;
            // 
            // rdbStatus2
            // 
            this.rdbStatus2.AutoSize = true;
            this.rdbStatus2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.rdbStatus2.Location = new System.Drawing.Point(124, 25);
            this.rdbStatus2.Name = "rdbStatus2";
            this.rdbStatus2.Size = new System.Drawing.Size(148, 29);
            this.rdbStatus2.TabIndex = 1;
            this.rdbStatus2.Text = "Đang sử dụng";
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
            this.btnFind.Location = new System.Drawing.Point(793, 140);
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
            this.groupBoxTitle2.TabIndex = 12;
            this.groupBoxTitle2.TabStop = false;
            this.groupBoxTitle2.Text = "Danh sách phòng";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.SlateGray;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colBuiding,
            this.colRoomId,
            this.colRoomName,
            this.colRoomDevice,
            this.colRoomCapacity,
            this.colRoomStatus,
            this.colErrorNote});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 35);
            this.listView1.Margin = new System.Windows.Forms.Padding(6);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1534, 533);
            this.listView1.TabIndex = 6;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            this.colSTT.Width = 67;
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
            // colRoomName
            // 
            this.colRoomName.Text = "Tên phòng";
            this.colRoomName.Width = 262;
            // 
            // colRoomDevice
            // 
            this.colRoomDevice.Text = "Trạng thái thiết bị";
            this.colRoomDevice.Width = 277;
            // 
            // colRoomCapacity
            // 
            this.colRoomCapacity.Text = "Sức Chứa";
            this.colRoomCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colRoomCapacity.Width = 135;
            // 
            // colRoomStatus
            // 
            this.colRoomStatus.Text = "Trạng thái";
            this.colRoomStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colRoomStatus.Width = 206;
            // 
            // colErrorNote
            // 
            this.colErrorNote.Text = "Nội dung lỗi";
            this.colErrorNote.Width = 398;
            // 
            // ROOM_tab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBoxTitle1);
            this.Controls.Add(this.groupBoxTitle2);
            this.Name = "ROOM_tab1";
            this.Size = new System.Drawing.Size(1570, 840);
            this.groupBoxTitle1.ResumeLayout(false);
            this.groupBoxTitle1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBoxTitle2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTitle1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbRoomCapacity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbRoomId;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox groupBoxTitle2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colBuiding;
        private System.Windows.Forms.ColumnHeader colRoomId;
        private System.Windows.Forms.ColumnHeader colRoomCapacity;
        private System.Windows.Forms.ColumnHeader colRoomStatus;
        private System.Windows.Forms.ColumnHeader colRoomName;
        private System.Windows.Forms.ColumnHeader colErrorNote;
        private System.Windows.Forms.RadioButton rdbStatus1;
        private System.Windows.Forms.RadioButton rdbStatus3;
        private System.Windows.Forms.RadioButton rdbStatus2;
        private System.Windows.Forms.CheckBox cbBigStatus;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.ColumnHeader colRoomDevice;
    }
}
