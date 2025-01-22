using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongMay_G4.controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static QLPhongMay_G4.loginPortal;

namespace QLPhongMay_G4.modal
{
    public partial class EMM_DEVICE : UserControl
    {
        private string checkTextChange;

        public EMM_DEVICE()
        {
            InitializeComponent();
            checkTextChange = cbRoomId.Text;

            btnDone.ForeColor = Color.FromName(GlobalData.colorText);
            btnDone.BackColor = Color.FromName(GlobalData.colorButtonDone);

            btnSaveEdit.ForeColor = Color.FromName(GlobalData.colorText);
            btnSaveEdit.BackColor = Color.FromName(GlobalData.colorButtonEdit);

            btnRemove.ForeColor = Color.FromName(GlobalData.colorText);
            btnRemove.BackColor = Color.Red;
            btnRemove.Visible = false;

            groupBox7.Enabled = false;
            DataTable dt = ld.inforDevice(dataDeviceId, "", "", "",2);
            if (dataDeviceId != "0")
            {
                groupBox7.Enabled = true;
                LoadDataDevice(dt);
                btnRemove.Visible = true;
                btnSaveEdit.Text = "Lưu chỉnh sửa";
                cbDeviceType.Enabled = false;
            }

            tbStatusNote.Enabled = false;
            if (radioButton2.Checked)
                tbStatusNote.Enabled = true;

            ld.loadCBDataDevice(cbDeviceType, 2);
            lr.loadCBDataRoom(cbRoomId, 0);

        }

        //DataTable dt = 
        string dataDeviceId = GlobalData.selectedDeviceId;
        loadDevice ld = new loadDevice();
        loadRoom lr = new loadRoom();  
        commonFormat cf = new commonFormat();   

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tbStatusNote.Enabled = false;
            if (radioButton2.Checked)
                tbStatusNote.Enabled = true;
        }

        void LoadDataDevice(DataTable dt)
        {
            string deviceNameSplit = dt.Rows[0][1].ToString();
            string[] parts = deviceNameSplit.Trim().Split('-');
            string SplitSTT = parts[parts.Length - 1];


            cbRoomId.Text = dt.Rows[0][5].ToString();
            cbDeviceType.Text = dt.Rows[0][2].ToString();
            nbudSTTDevice.Text = SplitSTT;
            tbStatusNote.Text = dt.Rows[0][4].ToString();

            //bool deviceStatus = false;
            if (dt.Rows[0][3].ToString() == "True")
                radioButton1.Checked = true;
            else 
                radioButton2.Checked = true;
        }

        void closeUserControl()
        {
            Form parentForm = this.FindForm();

            // Nếu tìm thấy Form cha, đóng nó
            if (parentForm != null)
            {
                EventManager.OnButtonClicked();
                parentForm.Close();
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            string roomId = cbRoomId.Text;
            string deviceType = cbDeviceType.Text;
            bool deviceStatus = false;
            string statusNote = "";
            string deviceSTT = nbudSTTDevice.Text;

            if (radioButton1.Checked)
                deviceStatus = true;
            if (radioButton2.Checked)
            {
                statusNote = tbStatusNote.Text;
                deviceStatus = false;
            }


            if (dataDeviceId == "0")
            {
                DialogResult dialog = MessageBox.Show(GlobalData.msbInsert, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (ld.checkEmpty(1, deviceSTT, deviceType, deviceStatus, roomId))
                    {
                        ld.insertDevice(deviceSTT, deviceType, deviceStatus, statusNote, roomId);
                        closeUserControl();
                    }
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show(GlobalData.msbUpdate, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    byte BytedeviceSTT = Convert.ToByte(deviceSTT);
                    ld.updateInforDevice(dataDeviceId, BytedeviceSTT, deviceType, deviceStatus, statusNote, roomId);
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(GlobalData.msbOut, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu tìm thấy Form cha, đóng nó
            if (dialog == DialogResult.Yes)
                closeUserControl();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string roomId = cbRoomId.Text;
            string deviceType = cbDeviceType.Text;
            byte deviceSTT = ((byte)nbudSTTDevice.Value);

            DialogResult dialog = MessageBox.Show(GlobalData.msbRemove, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                ld.removeDevice(deviceSTT, deviceType, roomId);
                closeUserControl();
            }
        }

        private void cbDeviceType_Validating(object sender, CancelEventArgs e)
        {            
            cf.verifyDataCombobox(cbDeviceType);
        }

        private void cbRoomId_Validating(object sender, CancelEventArgs e)
        {
            cf.verifyDataCombobox(cbRoomId);
        }

        private void nbudSTTDevice_Leave(object sender, EventArgs e)
        {
            cf.checkNumberCapacity(nbudSTTDevice);
        }
    }
}
