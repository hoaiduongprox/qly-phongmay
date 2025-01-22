namespace QLPhongMay_G4.modal
{
    partial class EMM_ROOM
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tbStatusNote = new System.Windows.Forms.TextBox();
            this.groupBoxTitle2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbRoomCapacity = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbRoomId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbNameBuilding = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbRoomName = new System.Windows.Forms.TextBox();
            this.groupBoxTitle1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBoxTitle2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTitle1
            // 
            this.groupBoxTitle1.Controls.Add(this.groupBox7);
            this.groupBoxTitle1.Controls.Add(this.btnRemove);
            this.groupBoxTitle1.Controls.Add(this.btnDone);
            this.groupBoxTitle1.Controls.Add(this.btnSaveEdit);
            this.groupBoxTitle1.Controls.Add(this.groupBox8);
            this.groupBoxTitle1.Controls.Add(this.groupBoxTitle2);
            this.groupBoxTitle1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxTitle1.Location = new System.Drawing.Point(14, 6);
            this.groupBoxTitle1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxTitle1.Name = "groupBoxTitle1";
            this.groupBoxTitle1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxTitle1.Size = new System.Drawing.Size(633, 575);
            this.groupBoxTitle1.TabIndex = 0;
            this.groupBoxTitle1.TabStop = false;
            this.groupBoxTitle1.Text = "Thông tin chi tiết phòng";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButton3);
            this.groupBox7.Controls.Add(this.radioButton2);
            this.groupBox7.Controls.Add(this.radioButton1);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(14, 298);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox7.Size = new System.Drawing.Size(604, 60);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Trạng thái";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioButton3.Location = new System.Drawing.Point(375, 26);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(140, 25);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "Đang hoạt động";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioButton2.Location = new System.Drawing.Point(226, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 25);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "Bảo trì";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioButton1.Location = new System.Drawing.Point(33, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(115, 25);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Phòng trống";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Gray;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Roboto", 14F);
            this.btnRemove.Location = new System.Drawing.Point(52, 516);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(159, 38);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Xoá phòng";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Gray;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Roboto", 14F);
            this.btnDone.Location = new System.Drawing.Point(429, 516);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(159, 38);
            this.btnDone.TabIndex = 16;
            this.btnDone.Text = "Hoàn tất";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.BackColor = System.Drawing.Color.Gray;
            this.btnSaveEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEdit.FlatAppearance.BorderSize = 0;
            this.btnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEdit.Font = new System.Drawing.Font("Roboto", 14F);
            this.btnSaveEdit.Location = new System.Drawing.Point(244, 516);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(159, 38);
            this.btnSaveEdit.TabIndex = 14;
            this.btnSaveEdit.Text = "Thêm phòng";
            this.btnSaveEdit.UseVisualStyleBackColor = false;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tbStatusNote);
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(14, 370);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox8.Size = new System.Drawing.Size(604, 122);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Ghi chú lỗi";
            // 
            // tbStatusNote
            // 
            this.tbStatusNote.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatusNote.Location = new System.Drawing.Point(27, 31);
            this.tbStatusNote.Margin = new System.Windows.Forms.Padding(6);
            this.tbStatusNote.MaxLength = 100;
            this.tbStatusNote.Multiline = true;
            this.tbStatusNote.Name = "tbStatusNote";
            this.tbStatusNote.Size = new System.Drawing.Size(553, 79);
            this.tbStatusNote.TabIndex = 9;
            // 
            // groupBoxTitle2
            // 
            this.groupBoxTitle2.Controls.Add(this.groupBox5);
            this.groupBoxTitle2.Controls.Add(this.groupBox4);
            this.groupBoxTitle2.Controls.Add(this.groupBox3);
            this.groupBoxTitle2.Controls.Add(this.groupBox6);
            this.groupBoxTitle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTitle2.Location = new System.Drawing.Point(14, 58);
            this.groupBoxTitle2.Name = "groupBoxTitle2";
            this.groupBoxTitle2.Size = new System.Drawing.Size(604, 231);
            this.groupBoxTitle2.TabIndex = 1;
            this.groupBoxTitle2.TabStop = false;
            this.groupBoxTitle2.Text = "Thông tin phòng";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbRoomCapacity);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(405, 32);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox5.Size = new System.Drawing.Size(175, 75);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sức chứa";
            // 
            // tbRoomCapacity
            // 
            this.tbRoomCapacity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoomCapacity.Location = new System.Drawing.Point(12, 31);
            this.tbRoomCapacity.Margin = new System.Windows.Forms.Padding(6);
            this.tbRoomCapacity.MaxLength = 3;
            this.tbRoomCapacity.Name = "tbRoomCapacity";
            this.tbRoomCapacity.Size = new System.Drawing.Size(152, 33);
            this.tbRoomCapacity.TabIndex = 0;
            this.tbRoomCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRoomCapacity_KeyPress);
            this.tbRoomCapacity.Leave += new System.EventHandler(this.tbRoomCapacity_Leave);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbRoomId);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(216, 32);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(175, 95);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mã phòng";
            // 
            // tbRoomId
            // 
            this.tbRoomId.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoomId.Location = new System.Drawing.Point(10, 31);
            this.tbRoomId.Margin = new System.Windows.Forms.Padding(6);
            this.tbRoomId.MaxLength = 5;
            this.tbRoomId.Name = "tbRoomId";
            this.tbRoomId.Size = new System.Drawing.Size(152, 33);
            this.tbRoomId.TabIndex = 30;
            this.tbRoomId.Leave += new System.EventHandler(this.tbRoomId_Leave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "I3-01";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbNameBuilding);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 32);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(175, 75);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Khu";
            // 
            // tbNameBuilding
            // 
            this.tbNameBuilding.Enabled = false;
            this.tbNameBuilding.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameBuilding.Location = new System.Drawing.Point(12, 31);
            this.tbNameBuilding.Margin = new System.Windows.Forms.Padding(6);
            this.tbNameBuilding.MaxLength = 5;
            this.tbNameBuilding.Name = "tbNameBuilding";
            this.tbNameBuilding.Size = new System.Drawing.Size(152, 33);
            this.tbNameBuilding.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbRoomName);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(27, 139);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox6.Size = new System.Drawing.Size(553, 75);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tên phòng";
            // 
            // tbRoomName
            // 
            this.tbRoomName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoomName.Location = new System.Drawing.Point(12, 31);
            this.tbRoomName.Margin = new System.Windows.Forms.Padding(6);
            this.tbRoomName.MaxLength = 100;
            this.tbRoomName.Name = "tbRoomName";
            this.tbRoomName.Size = new System.Drawing.Size(530, 33);
            this.tbRoomName.TabIndex = 0;
            // 
            // EMM_ROOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxTitle1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EMM_ROOM";
            this.Size = new System.Drawing.Size(660, 587);
            this.groupBoxTitle1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBoxTitle2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTitle1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox tbStatusNote;
        private System.Windows.Forms.GroupBox groupBoxTitle2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbRoomCapacity;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbNameBuilding;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbRoomName;
        private System.Windows.Forms.TextBox tbRoomId;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}
