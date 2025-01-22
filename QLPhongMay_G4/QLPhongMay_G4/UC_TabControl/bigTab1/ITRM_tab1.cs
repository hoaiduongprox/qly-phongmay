using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QLPhongMay_G4.controllers;
using static QLPhongMay_G4.loginPortal;
using static QLPhongMay_G4.editRoomRequest;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using Aspose.Words.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace QLPhongMay_G4.UC_TabControl
{
    public partial class ITRM_tab1 : UserControl
    {
        
        public ITRM_tab1()
        {
            string accountID = GlobalData.dataUserId;
            InitializeComponent();
            lr.loadCBDataRoom(cbRoomId, 0); 
            lr.loadCBDataRoom(cbRoomCapacity, 4);            
            lrequestr.insertUsageRoom(accountID);
            lrequestr.updateRoomStatusUsing();
            btnAddRequestRoom.BackColor = Color.FromName(GlobalData.colorButtonUpdate);
            btnFind.BackColor = Color.FromName(GlobalData.colorButtonDone);

            EventManager.ButtonClicked += btnFind_Click;
        }

        loadRoom lr = new loadRoom();
        loadRequestRoom lrequestr = new loadRequestRoom();
        commonFormat cf = new commonFormat();
        private string patternTime = @"^(0[0-9]|1[0-9]|2[0-3]):(0[0-9]|[1-5][0-9])$";
        private string patternDate = @"^\d{2}/\d{2}/\d{4}$";

        private void cbRoomId_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            cf.verifyDataCombobox(cbRoomId);
            //e.Cancel = true; // Ngăn người dùng rời khỏi ComboBox
        }
               
        void findInformationRoom(DataTable dt)
        {
            //listView1.Items.Clear();
            //DataTable dt = lrequestr.findRequestRoom(roomId, capacity, usageDate, startTime, endTime, usageOccupied);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int countItem = i + 1;
                ListViewItem lvi =
                listView1.Items.Add(countItem.ToString());
                lvi.SubItems.Add("Khu I");
                lvi.SubItems.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString() + " chổ");

                //
                bool usageToday = false;
                if (DateTime.TryParse(dt.Rows[i][3].ToString(), out DateTime date))
                {
                    lvi.SubItems.Add(date.ToString("dd/MM/yyyy"));

                    if (date.Date == DateTime.Today)
                        usageToday = true;
                }
                else
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());

                //
                bool usageFormTime = false;
                if (DateTime.TryParse(dt.Rows[i][4].ToString(), out DateTime time))
                {
                    lvi.SubItems.Add(time.ToString("HH:mm"));

                    if (time.TimeOfDay <= DateTime.Now.TimeOfDay)
                        usageFormTime = true;
                }
                else
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());

                //
                bool usageToTime = false;
                if (DateTime.TryParse(dt.Rows[i][5].ToString(), out DateTime time1))
                {
                    lvi.SubItems.Add(time1.ToString("HH:mm"));

                    if (time1.TimeOfDay >= DateTime.Now.TimeOfDay)
                        usageToTime = true;
                }
                else
                    lvi.SubItems.Add(dt.Rows[i][5].ToString());

                string status = "Đã đăng ký";
                if (usageToday && usageFormTime && usageToTime)
                {
                    status = "Đang sử dụng";
                    lrequestr.updateStatusRoom(dt.Rows[i][8].ToString(), 1);
                }
                else
                    lrequestr.updateStatusRoom(dt.Rows[i][8].ToString(), 0);

                lvi.SubItems.Add(status);
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
                lvi.SubItems.Add(dt.Rows[i][8].ToString());
            }
        }

        public void loadInformationRoom()
        {
            string roomId = cbRoomId.Text;
            string capacity = cbRoomCapacity.Text;
            string usageDate = tbUsageDate.Text;
            string startTime = tbStartTime.Text;
            string endTime = tbEndTime.Text;
            byte usageOccupied = 0;

            if (cbRoomStatus.Checked)
                usageOccupied = 1;

            listView1.Items.Clear();

            string userIdSelected = "";
            if (GlobalData.dataUserRole == "user")
                userIdSelected = GlobalData.dataUserId;

            DataTable dt = lrequestr.findRequestRoom(roomId, capacity, usageDate, startTime, endTime, usageOccupied, userIdSelected);
            findInformationRoom(dt);
        }

        private void tbUsageDate_Leave(object sender, EventArgs e)
        {
            string pattern = patternDate;
            cf.checkPatternIn(tbUsageDate, pattern);
        }

        private void tbStartTime_Leave(object sender, EventArgs e)
        {
            string pattern = patternTime;
            cf.checkPatternIn(tbStartTime, pattern);
        }

        private void tbEndTime_Leave(object sender, EventArgs e)
        {
            string pattern = patternTime;
            cf.checkPatternIn(tbEndTime, pattern);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (GlobalData.dataUserRole != "user")
            {
                processToForm.dataButtonF1toF2 = true; 
                string RequestIdSelect = listView1.SelectedItems[0].SubItems[10].Text;
                cf.openEditRequest(RequestIdSelect);         

            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            loadInformationRoom();
        }

        private void btnAddRequestRoom_Click(object sender, EventArgs e)
        {
            processToForm.dataButtonF1toF2 = false;
            editRoomRequest form3 = new editRoomRequest();
            form3.ShowDialog();
        }

        private void cbRoomCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và phím Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void cbRoomCapacity_Leave(object sender, EventArgs e)
        {
            
        }

        private void cbRoomCapacity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            cf.verifyDataCombobox(cbRoomCapacity);
        }
        
    }
}