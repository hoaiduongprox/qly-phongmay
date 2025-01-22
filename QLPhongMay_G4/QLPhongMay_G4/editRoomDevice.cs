using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using QLPhongMay_G4.controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static QLPhongMay_G4.loginPortal;

namespace QLPhongMay_G4
{
    public partial class editRoomRequest : Form
    {

        database db;
        public editRoomRequest()
        {
            InitializeComponent();
            db = new database();

            DataTable result = lu.findUserID(accountID,"","");

            if (result.Rows.Count > 0)
            {
                DataRow dataRowFirst = result.Rows[0];
                lbAdmin.Text = dataRowFirst["fullName"].ToString();

            }
            else
            {
                lbAdmin.Text = "Không tìm thấy thông tin người dùng!";
            }
        }

        private string patternTime = @"^(0[0-9]|1[0-9]|2[0-3]):(0[0-9]|[1-5][0-9])$";
        private string patternDate = @"^\d{2}/\d{2}/\d{4}$";
        commonFormat cf = new commonFormat();
        string accountID = GlobalData.dataUserId;
        loadRequestRoom lrequestr = new loadRequestRoom();
        loadRoom lr = new loadRoom();
        loadUser lu = new loadUser();
        private string requestIdSelect = GlobalData.dataRequestId;


        //Nhan du lieu tu luong nao
        public static class processToForm
        {
            public static bool dataButtonF1toF2 { get; set; } = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (processToForm.dataButtonF1toF2)
            {
                DataTable dtData = lrequestr.loadInforRequests(requestIdSelect);
                tbUserID.Text = dtData.Rows[0][0].ToString();
                tbFullName.Text = dtData.Rows[0][1].ToString();
                tbNameRoom.Text = "Khu I";
                tbRoomName.Text = dtData.Rows[0][3].ToString();
                tbRoomId.Text = dtData.Rows[0][2].ToString();
                tbRoomCapacity.Text = dtData.Rows[0][4].ToString();

            
                tbUsageDate.Text = DateTime.Parse(dtData.Rows[0][5].ToString()).ToString("dd/MM/yyyy");


                tbStartTime.Text = DateTime.Parse(dtData.Rows[0][6].ToString()).ToString("HH:mm");


                tbEndTime.Text = DateTime.Parse(dtData.Rows[0][7].ToString()).ToString("HH:mm");

                tbRequestReason.Text = dtData.Rows[0][8].ToString();
                tbAdminNote.Text = dtData.Rows[0][9].ToString();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            DateTime parsedDate = DateTime.ParseExact(tbUsageDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string formattedDate = parsedDate.ToString("MM/dd/yyyy");

            string inRequestUserID = tbUserID.Text;
            string inRequestRoomId = tbRoomId.Text;
            string inRequestUsageDate = formattedDate;
            string inRequestStartTime = tbStartTime.Text;
            string inRequestEndTime = tbEndTime.Text;
            string inRequestRequestReason = tbRequestReason.Text;
            string inRequestAdminNote = tbAdminNote.Text;

            lrequestr.updateInforBookingRoom(
                inRequestUsageDate
                , inRequestRequestReason
                , inRequestAdminNote
                , inRequestUserID
                , inRequestRoomId
                , inRequestStartTime
                , inRequestEndTime
                , requestIdSelect);
        }

        private void tbRoomId_Leave(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9]{2}-[a-zA-Z0-9]{2}$";
            cf.checkPatternIn(tbRoomId, pattern);

            if (tbRoomId.Text != string.Empty)
            {
                DataTable dtData = lr.inforRoom(tbRoomId.Text.ToString(), 3, "");
                tbRoomName.Text = dtData.Rows[0][1].ToString();
                tbRoomCapacity.Text = dtData.Rows[0][4].ToString();
            }
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

        private void tbUsageDate_Leave(object sender, EventArgs e)
        {
            string pattern = patternDate;
            cf.checkPatternIn(tbUsageDate, pattern);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lrequestr.removeFormRequest(requestIdSelect);
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xoá không?", "Xoá đơn đăng ký", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void tbUserID_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbUserID.Text))
            {
                DataTable dataRowFirst = lu.findUserID(tbUserID.Text, "", "");
                tbFullName.Text = dataRowFirst.Rows[0][1].ToString();

            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng!");
            }

        }
    }
}
