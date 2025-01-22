using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static QLPhongMay_G4.loginPortal;

namespace QLPhongMay_G4.modal
{
    public partial class EMM_ROOM : UserControl
    {
        public EMM_ROOM()
        {
            InitializeComponent();

            tbNameBuilding.Text = "Khu I";
            btnDone.ForeColor = Color.FromName(GlobalData.colorText);
            btnDone.BackColor = Color.FromName(GlobalData.colorButtonDone);

            btnSaveEdit.ForeColor = Color.FromName(GlobalData.colorText);
            btnSaveEdit.BackColor = Color.FromName(GlobalData.colorButtonEdit);
            
            btnRemove.BackColor = Color.Red;
            btnRemove.Visible = false;
            btnRemove.ForeColor = Color.FromName(GlobalData.colorText);

            //groupBox7.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            DataTable dt = lr.inforRoom(selectedRoomId, 3, "");
            if (selectedRoomId != "0")
            {
                LoadDataRoom(dt);
                btnRemove.Visible = true;
                btnSaveEdit.Text = "Lưu chỉnh sửa";
                //groupBox7.Enabled = true;

                tbRoomId.Enabled = false;
            }

            tbStatusNote.Enabled = false;
            if (radioButton2.Checked)
                tbStatusNote.Enabled = true;
        }

        string selectedRoomId = GlobalData.selectedRoomId;
        loadRoom lr = new loadRoom();
        commonFormat cf = new commonFormat();
        private string PatternRoomID = @"^[A-Za-z]\d-\d{2}$";

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tbStatusNote.Enabled = false;
            if (radioButton2.Checked)
                tbStatusNote.Enabled = true;
        }

        void LoadDataRoom(DataTable dt)
        {            
            tbRoomId.Text = dt.Rows[0][0].ToString();
            tbRoomName.Text = dt.Rows[0][1].ToString();
            tbRoomCapacity.Text = dt.Rows[0][4].ToString();

            if (dt.Rows[0][2].ToString() == "free")
            {
                radioButton1.Checked = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
            }
            if (dt.Rows[0][2].ToString() == "maintenance")
            {
                radioButton2.Checked = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                tbStatusNote.Text = dt.Rows[0][3].ToString();
            }
            if (dt.Rows[0][2].ToString() == "inuse")
            {
                radioButton3.Checked = true;
                radioButton3.Enabled = true;
            }
        }

        void closeThisForm(){
            Form parentForm = this.FindForm();
            // Nếu tìm thấy Form cha, đóng nó
            if (parentForm != null)
            {
                EventManager.OnButtonClicked();
                parentForm.Close();
            }
        }        
        
        
        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(GlobalData.msbOut, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu tìm thấy Form cha, đóng nó
            if (dialog == DialogResult.Yes)
                closeThisForm();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            string roomId = tbRoomId.Text;
            string roomName = tbRoomName.Text;
            string roomCapacity = tbRoomCapacity.Text;
            string roomErrorNote = "";
            byte roomStatus = 3;

            if (radioButton1.Checked == true)
                roomStatus = 0;
            if (radioButton3.Checked == true)
                roomStatus = 1;
            if (radioButton2.Checked == true)
            {
                roomStatus = 2; 
                roomErrorNote = tbStatusNote.Text;
            }

            if (selectedRoomId != "0")
            {
                DialogResult dialog = MessageBox.Show(GlobalData.msbUpdate, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialog == DialogResult.Yes)
                    lr.updateInforRoom(roomId, roomName, roomStatus, roomErrorNote, roomCapacity);
                    
            }
            else
            {                
                DialogResult dialog = MessageBox.Show(GlobalData.msbInsert, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialog == DialogResult.Yes)
                    if (lr.checkEmpty(1, roomId, roomName, roomStatus, roomCapacity))
                    {
                        if (lr.checkEmpty(1, roomId, roomName, roomStatus, roomCapacity))
                        {
                            lr.insertRoom(roomId, roomName, roomStatus, roomErrorNote, roomCapacity);
                            closeThisForm();
                        }
                    }
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string selectedRoomId = GlobalData.selectedRoomId;

            DialogResult dialog = MessageBox.Show(GlobalData.msbRemove, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                lr.removeRoom(selectedRoomId);
                closeThisForm();
            }
        }

        private void tbRoomCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void tbRoomId_Leave(object sender, EventArgs e)
        {
            string pattern = PatternRoomID;
            cf.checkPatternIn(tbRoomId, pattern);
        }

        private void tbRoomCapacity_Leave(object sender, EventArgs e)
        {
            cf.checkNumberCapacity(tbRoomCapacity);
        }
    }
}
