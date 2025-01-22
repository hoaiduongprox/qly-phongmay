using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongMay_G4.controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static QLPhongMay_G4.editMiniModal;
using static QLPhongMay_G4.loginPortal;

namespace QLPhongMay_G4.UC_TabControl.bigTab3
{
    public partial class DEVICE_tab1 : UserControl
    {
        public DEVICE_tab1()
        {
            InitializeComponent();
            formOpenMiniModal.modal = "device";
            ld.loadCBDataDevice(cbDeviceType, 2);
            lr.loadCBDataRoom(cbRoomId, 0);
            groupBox6.Enabled = false;
            btnAddDevice.BackColor = Color.FromName(GlobalData.colorButtonUpdate);
            btnFind.BackColor = Color.FromName(GlobalData.colorButtonDone);

            EventManager.ButtonClicked += btnFind_Click;
        }

        loadDevice ld = new loadDevice();
        loadRoom lr = new loadRoom();
        commonFormat cf = new commonFormat();

        void loadInforDevice(DataTable dt)
        {
            listView1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int countItem = i + 1;
                ListViewItem lvi =
                listView1.Items.Add(countItem.ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());

                string changeDType = ld.getDeviceTypeVIE(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(changeDType);

                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add("Khu I");
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][0].ToString());
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string roomId = cbRoomId.Text;
            string deviceId = cbDeviceId.Text;
            //string deviceName = tbDeviceName.Text;
            string deviceType = cbDeviceType.Text;
            byte status = 2;


            if (cbBigStatus.Checked)
            {
                if (rdbStatus1.Checked)
                    status = 1;

                if (rdbStatus2.Checked)
                    status = 0;
            }

            
            DataTable dt = ld.inforDevice("", roomId, deviceId, deviceType, status);
            loadInforDevice(dt);
        }

        private void cbBigStatus_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Enabled = false;

            if (cbBigStatus.Checked)
                groupBox6.Enabled = true;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string DeviceIdSelect = listView1.SelectedItems[0].SubItems[7].Text;
            cf.openEditMiniModal(DeviceIdSelect);
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            string DeviceIdSelect = "0";
            cf.openEditMiniModal(DeviceIdSelect);
        }

        private void cbRoomId_Validating(object sender, CancelEventArgs e)
        {
            cf.verifyDataCombobox(cbRoomId);

        }

        private void cbDeviceId_Validating(object sender, CancelEventArgs e)
        {
            cf.checkNumberCapacity(cbDeviceId);

        }

        private void cbDeviceType_Validating(object sender, CancelEventArgs e)
        {
            cf.verifyDataCombobox(cbDeviceType);
        }

        private void cbDeviceId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và phím Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }
    }
}
