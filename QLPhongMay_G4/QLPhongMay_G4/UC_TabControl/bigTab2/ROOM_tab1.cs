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
using QLPhongMay_G4.modal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static QLPhongMay_G4.editMiniModal;
using static QLPhongMay_G4.editRoomRequest;
using static QLPhongMay_G4.loginPortal;

namespace QLPhongMay_G4.UC_TabControl.bigTab2
{
    public partial class ROOM_tab1 : UserControl
    {
        public ROOM_tab1()
        {
            InitializeComponent();
            formOpenMiniModal.modal = "room";
            lr.loadCBDataRoom(cbRoomId, 0);
            lr.loadCBDataRoom(cbRoomCapacity, 4);
            lrr.updateRoomStatusUsing();
            groupBox4.Enabled = false;

            btnAddRoom.BackColor = Color.FromName(GlobalData.colorButtonUpdate);
            btnFind.BackColor = Color.FromName(GlobalData.colorButtonDone);

            if (GlobalData.dataUserRole == "user")
            {
                btnFind.Location = new Point(670, 140);
                //
                btnAddRoom.Visible = false;
            }

            EventManager.ButtonClicked += btnFind_Click;
        }

        loadRequestRoom lrr = new loadRequestRoom();
        loadRoom lr = new loadRoom();
        loadDevice ld = new loadDevice();
        commonFormat cf = new commonFormat();

        void loadInforRoom(DataTable dt)
        {
            listView1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int countItem = i + 1;
                ListViewItem lvi =
                listView1.Items.Add(countItem.ToString());
                lvi.SubItems.Add("Khu I");
                lvi.SubItems.Add(dt.Rows[i][0].ToString());
                
                lvi.SubItems.Add(dt.Rows[i][1].ToString());

                string a = ld.stringCountDeviceInRoom(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(a);

                lvi.SubItems.Add(dt.Rows[i][4].ToString());

                string statusIn = dt.Rows[i][2].ToString();
                string statusOut = "";
                if (statusIn == "free")
                    statusOut = "Phòng trống";
                if (statusIn == "maintenance")
                    statusOut = "Bảo trì";
                if (statusIn == "inuse")
                    statusOut = "Đang sử dụng";
                
                lvi.SubItems.Add(statusOut);
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string roomId = cbRoomId.Text;
            string capacity = cbRoomCapacity.Text;
            byte status = 3;

            if (cbBigStatus.Checked)
            {
                if (rdbStatus1.Checked)
                    status = 0;

                if (rdbStatus2.Checked)
                    status = 1;

                if (rdbStatus3.Checked)
                    status = 2;
            }

            DataTable dt = lr.inforRoom(roomId, status, capacity);
            loadInforRoom(dt);
        }

        private void cbBigStatus_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = false;

            if (cbBigStatus.Checked)
                groupBox4.Enabled = true;
        }   

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (GlobalData.dataUserRole != "user")
            {
                string RoomIdSelected = listView1.SelectedItems[0].SubItems[2].Text;
                cf.openEditMiniModal(RoomIdSelected);
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string RoomIdSelected = "0"; //Reset textbox
            cf.openEditMiniModal(RoomIdSelected);
        }

        private void cbRoomId_Validating(object sender, CancelEventArgs e)
        {
            cf.verifyDataCombobox(cbRoomId);
        }

        private void cbRoomCapacity_Validating(object sender, CancelEventArgs e)
        {
            cf.verifyDataCombobox(cbRoomCapacity);
        }

        private void cbRoomCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
