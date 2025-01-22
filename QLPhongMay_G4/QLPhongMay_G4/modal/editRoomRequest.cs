using Aspose.Words;
using QLPhongMay_G4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using QLPhongMay_G4.controllers;
using QLPhongMay_G4.UC_TabControl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static QLPhongMay_G4.loginPortal;
using Aspose.Words.Tables;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.IO;

namespace QLPhongMay_G4
{
    public partial class editRoomRequest : Form
    {
        database db;
        public editRoomRequest()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            db = new database();

            btnDone.BackColor = Color.FromName(GlobalData.colorButtonDone);
            btnRemove.BackColor = Color.Red;
            btnSaveEdit.BackColor = Color.FromName(GlobalData.colorButtonEdit);


            lr.loadCBDataRoom(cbRoomId, 0);
            tbNameBuilding.Text = "Khu I";
            tbNameBuilding.Enabled = false;

            if (!string.IsNullOrEmpty(accountID))
            {
                DataTable dataRowFirst = lu.findUserID(accountID, 3);
                lbAdmin.Text = dataRowFirst.Rows[0][4].ToString();
            }
            else
            {
                MessageBox.Show(GlobalData.msbErrorUser, "Thông báo");
            }

            if (processToForm.verifyFormTab2)
            {
                if (GlobalData.dataUserRole == "user")
                {
                    btnSaveEdit.Text = "Lưu và gửi duyệt";
                    tbUserID.Enabled = false;
                }

                btnSaveEdit.Text = "Lưu và duyệt";
            }

            if (processToForm.dataButtonF1toF2)
            {
                DataTable dtData = lrequestr.loadInforRequests(requestIdSelect, "");

                //string userIdSelected = "";
                //if (GlobalData.dataUserRole == "user")
                //    userIdSelected = GlobalData.dataUserId;

                tbUserID.Text = dtData.Rows[0][0].ToString();
                tbFullName.Text = dtData.Rows[0][1].ToString();
                tbNameBuilding.Text = "Khu I";
                tbRoomName.Text = dtData.Rows[0][3].ToString();
                cbRoomId.Text = dtData.Rows[0][2].ToString();
                tbRoomCapacity.Text = dtData.Rows[0][4].ToString();


                tbUsageDate.Text = DateTime.Parse(dtData.Rows[0][5].ToString()).ToString("dd/MM/yyyy");


                tbStartTime.Text = DateTime.Parse(dtData.Rows[0][6].ToString()).ToString("HH:mm");


                tbEndTime.Text = DateTime.Parse(dtData.Rows[0][7].ToString()).ToString("HH:mm");

                tbRequestReason.Text = dtData.Rows[0][8].ToString();
                tbAdminNote.Text = dtData.Rows[0][9].ToString();
            }
            else
            {
                if (GlobalData.dataUserRole == "user")
                {
                    tbUserID.Text = GlobalData.dataUserId;
                    tbUserID.Enabled = false;
                    DataTable result = lu.findUserID(tbUserID.Text, 3);
                    tbFullName.Text = result.Rows[0][4].ToString();
                }

                btnSaveEdit.Text = "Thêm đơn";
                btnRemove.Visible = false;
            }
        }

        private string patternTime = @"^(0[0-9]|1[0-9]|2[0-3]):(0[0-9]|[1-5][0-9])$";
        //private string patternDate = @"^\d{2}/\d{2}/\d{4}$";
        private string patternDate = @"^([0-9]|1[0-9]|2[0-9]|3[0-1])/(0[0-9]|1[0-2])/\d{4}$";
        commonFormat cf = new commonFormat();
        string accountID = GlobalData.dataUserId;
        loadRequestRoom lrequestr = new loadRequestRoom();
        loadRoom lr = new loadRoom();
        loadUser lu = new loadUser();
        itRoomManagement itRoomManagement = new itRoomManagement();
        private string requestIdSelect = GlobalData.selectedRequestId;


        //Nhan du lieu tu luong nao
        public static class processToForm
        {
            public static bool dataButtonF1toF2 { get; set; } = false;
            public static bool verifyFormTab2 { get; set; } = false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(GlobalData.msbOut, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                EventManager.OnButtonClicked();
                this.Close();
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (processToForm.dataButtonF1toF2)
                result = MessageBox.Show(GlobalData.msbUpdate, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            else
                result = MessageBox.Show(GlobalData.msbInsert + ", Đơn này sẽ được gửi vào hàng chờ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes) 
            { 
                string formattedDate = tbUsageDate.Text;

                string inRequestUserID = tbUserID.Text;
                string inRequestRoomId = cbRoomId.Text;
                string inRequestUsageDate = formattedDate;
                string inRequestStartTime = tbStartTime.Text;
                string inRequestEndTime = tbEndTime.Text;
                string inRequestRequestReason = tbRequestReason.Text;
                string inRequestAdminNote = tbAdminNote.Text;
            
                if (processToForm.dataButtonF1toF2)
                {
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
                else
                {
                    if (lrequestr.checkEmpty(1, inRequestUsageDate, inRequestRequestReason, inRequestUserID, inRequestRoomId, inRequestStartTime, inRequestEndTime))
                    {
                        lrequestr.insertSignUpRoom(
                            inRequestUsageDate
                            , inRequestRequestReason
                            , 0 //sẽ đưa vào hàng chờ để duyệt
                            , inRequestAdminNote
                            , inRequestUserID
                            , inRequestRoomId
                            , inRequestStartTime
                            , inRequestEndTime);

                        this.Close();
                    }

                }
                
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
            DialogResult result = MessageBox.Show(GlobalData.msbRemove, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lrequestr.removeFormRequest(requestIdSelect);
                EventManager.OnButtonClicked();
                this.Close();
            }
        }

        private void tbUserID_Leave(object sender, EventArgs e)
        {
            DataTable result = lu.findUserID(tbUserID.Text, 3);
            if (result.Rows.Count > 0 && tbUserID.Text != string.Empty)
            {
                tbFullName.Text = result.Rows[0][4].ToString();
            }
            else
            {
                MessageBox.Show(GlobalData.msbErrorUser, "Thông báo");
                tbUserID.Clear();
                tbFullName.Clear();
            }
        }

        private void cbRoomId_Leave(object sender, EventArgs e)
        {
            if (!cbRoomId.Items.Contains(cbRoomId.Text) && !string.IsNullOrEmpty(cbRoomId.Text))
            {
                MessageBox.Show(GlobalData.msbKeypress,
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                cbRoomId.Text = string.Empty;
            }
            else
            {
                DataTable dtData = lr.inforRoom(cbRoomId.Text.ToString(), 3, "");
                tbRoomName.Text = dtData.Rows[0][1].ToString();
                tbRoomCapacity.Text = dtData.Rows[0][4].ToString();
            }
        }

        private void tbUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        void ExportWord()
        {
            var toDay = DateTime.Now;

            string relativePath = @"template\DonXinMuonPhong.doc";
            string absolutePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
            Document template = new Document(absolutePath);

            string getMonth = toDay.Month.ToString();
            if (getMonth == "2" || getMonth == "1")
                getMonth = toDay.ToString("MM");


            //Bước 2: Điền các thông tin cố định
            template.MailMerge.Execute(new[] { "toFromtoDay" }, new[] { string.Format("Cần Thơ, ngày {0} tháng {1} năm {2}", toDay.ToString("dd"), getMonth, toDay.Year) });
            template.MailMerge.Execute(new[] { "NameUser" }, new[] { tbFullName.Text });
            template.MailMerge.Execute(new[] { "MSSVMSCB" }, new[] { tbUserID.Text });
            template.MailMerge.Execute(new[] { "roomId" }, new[] { cbRoomId.Text });
            template.MailMerge.Execute(new[] { "roomName" }, new[] { tbRoomName.Text });
            template.MailMerge.Execute(new[] { "requestDay" }, new[] { tbUsageDate.Text });
            template.MailMerge.Execute(new[] { "requestTimeStart" }, new[] { tbStartTime.Text });
            template.MailMerge.Execute(new[] { "requestTimeEnd" }, new[] { tbEndTime.Text });
            template.MailMerge.Execute(new[] { "requestNote" }, new[] { tbRequestReason.Text });
            template.MailMerge.Execute(new[] { "requestNoteAdmin" }, new[] { tbAdminNote.Text });
            template.MailMerge.Execute(new[] { "NameAdmin" }, new[] { lbAdmin.Text });

            //Bước 3: Lưu và mở file
            string getNameReplacce = tbUsageDate.Text.Replace("/", "");
            string nameFileEx = cbRoomId.Text + "_" + tbUserID.Text + "_" + getNameReplacce;
            template.SaveAndOpenFile(nameFileEx + ".pdf");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("File đang được mở vui lòng chờ giây lát!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ExportWord();
        }

        private void tbUsageDate_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
