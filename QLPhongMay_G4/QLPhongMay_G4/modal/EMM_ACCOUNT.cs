using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLPhongMay_G4.commonFormat;
using static QLPhongMay_G4.loginPortal;

namespace QLPhongMay_G4.modal
{
    public partial class EMM_ACCOUNT : UserControl
    {
        public EMM_ACCOUNT()
        {
            InitializeComponent();

            btnDone.BackColor = Color.FromName(GlobalData.colorButtonDone);
            btnRemove.BackColor = Color.Red;
            btnSaveEdit.BackColor = Color.FromName(GlobalData.colorButtonEdit);
            btnDone.ForeColor = Color.FromName(GlobalData.colorText);
            btnSaveEdit.ForeColor = Color.FromName(GlobalData.colorText);
            btnRemove.ForeColor = Color.FromName(GlobalData.colorText);




            cbUserRole.Items.Add("Người đăng ký");
            cbUserRole.Items.Add("Quản lý");
            cbUserRole.Items.Add("Quản trị");

            string selectedUserId = GlobalData.selectedUserId;
            DataTable dt = lu.findUserID(selectedUserId, 3);
            loadDataAccount(dt);
        }

        loadUser lu = new loadUser();
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        commonFormat cf = new commonFormat();

        void loadDataAccount(DataTable dt)
        {
            tbUserId.Text = dt.Rows[0][0].ToString();
            tbFullName.Text = dt.Rows[0][4].ToString();
            tbEmail.Text = dt.Rows[0][2].ToString();


            string roleIn = dt.Rows[0][5].ToString();
            string roleOut = "";

            if (roleIn == "admin")
                roleOut = "Quản trị";
            else if (roleIn == "manager")
                roleOut = "Quản lý";
            else
                roleOut = "Người đăng ký";

            cbUserRole.Text = roleOut;

            tbUserPass.Text = dt.Rows[0][3].ToString();

            string checkStatus = dt.Rows[0][6].ToString();
            if (checkStatus.ToString() == "True")
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

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(GlobalData.msbOut, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                closeUserControl();
        }

        private void btnShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            tbUserPass.PasswordChar = '\0';

        }

        private void btnShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            tbUserPass.PasswordChar = '⬤';

        }

        private void tbUserPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cf.IsVietnameseCharacter(e.KeyChar))
            {
                // Chặn ký tự
                e.Handled = true;
            }
        }

        private void tbUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void cbUserRole_Validating(object sender, CancelEventArgs e)
        {
            cf.verifyDataCombobox(cbUserRole);
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            tbEmail.Clear();
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            string pattern = emailPattern;
            cf.checkPatternIn(tbEmail, pattern);
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            string userID = tbUserId.Text;
            string fullName = tbFullName.Text;
            string userEmail = tbEmail.Text;


            string roleIn = cbUserRole.Text;
            byte roleOut = 0;

            if (roleIn == "Quản trị")
                roleOut = 2;
            else if (roleIn == "Quản lý")
                roleOut = 1;
            else
                roleOut = 0;

            byte checkStatus = 0;
            if (radioButton1.Checked == true)
                checkStatus = 1;
            else
                checkStatus = 0;
            
            DialogResult dialog = MessageBox.Show(GlobalData.msbInsert, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                lu.updateInforAccount(userID, userEmail, fullName, roleOut, checkStatus);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string userID = tbUserId.Text;
            
            DialogResult dialog = MessageBox.Show(GlobalData.msbRemove, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                closeUserControl();
                lu.removeAccount(userID);
            }
        }
    }
}
