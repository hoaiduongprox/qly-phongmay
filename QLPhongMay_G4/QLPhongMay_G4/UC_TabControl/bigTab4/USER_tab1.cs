using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static QLPhongMay_G4.loginPortal;

namespace QLPhongMay_G4.UC_TabControl.bigTab4
{
    public partial class USER_tab1 : UserControl
    {
        byte getUserID_Role = 0;
        byte getUserID_Status = 0;

        public USER_tab1()
        {
            InitializeComponent();

            btnUpdate.BackColor = Color.FromName(GlobalData.colorButtonDone);

            cbUserRole.Items.Add("Người đăng ký");
            cbUserRole.Items.Add("Quản lý");
            cbUserRole.Items.Add("Quản trị");


            //default
            tbUserPassNew.PasswordChar = '⬤';
                        
            DataTable dt = lu.findUserID(AccountID, 3);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string userId = dt.Rows[i][0].ToString();
                string userMail = dt.Rows[i][2].ToString();
                string fullName = dt.Rows[i][4].ToString();
                string userRole = dt.Rows[i][5].ToString();

                if (userRole == "user")
                {                        
                    cbUserRole.Text = "Người đăng ký";
                    getUserID_Role = 0;
                }
                if (userRole == "manager")
                {
                    cbUserRole.Text = "Quản lý";
                    getUserID_Role = 1;
                }
                if (userRole == "admin")
                {
                    cbUserRole.Text = "Quản trị";
                    getUserID_Role = 2;
                }

                string userStatus = dt.Rows[i][6].ToString();

                tbUserId.Text = userId;
                tbUserEmail.Text = userMail;
                tbFullName.Text = fullName;


                if (userStatus == "True")
                    getUserID_Status = 1;
                else
                    getUserID_Status = 0;
            }
        }

        string AccountID = GlobalData.dataUserId;
        commonFormat cf = new commonFormat();
        loadUser lu = new loadUser();
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        private void tbUserEmail_Leave(object sender, EventArgs e)
        {
            string pattern = emailPattern;
            cf.checkPatternIn(tbUserEmail, pattern);
        }

        private void btnShowPassNew_MouseDown(object sender, MouseEventArgs e)
        {
            ;
            tbUserPassNew.PasswordChar = '\0';
        }

        private void btnShowPassNew_MouseUp(object sender, MouseEventArgs e)
        {
            tbUserPassNew.PasswordChar = '⬤';

        }

        private void btnShowPassOld_MouseDown(object sender, MouseEventArgs e)
        {
            tbUserPassOld.PasswordChar = '\0';

        }

        private void btnShowPassOld_MouseUp(object sender, MouseEventArgs e)
        {
            tbUserPassOld.PasswordChar = '⬤';

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string userId = AccountID;
            string userMail = tbUserEmail.Text;
            string fullName = tbFullName.Text;
            byte userRole = getUserID_Role;
            byte userStatus = getUserID_Status;

            string userPassOld = tbUserPassOld.Text;
            string userPassNew = tbUserPassNew.Text;
            DataTable findPassOld = lu.findUserID(userId, 3);

            if (string.IsNullOrEmpty(tbUserEmail.Text) || string.IsNullOrEmpty(tbFullName.Text))
                MessageBox.Show(GlobalData.msbKeypressFull, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (String.IsNullOrEmpty(userPassOld) && String.IsNullOrEmpty(userPassNew))
                {
                    DialogResult result = MessageBox.Show(GlobalData.msbUpdate, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                        lu.updateInforAccount(userId, userMail, fullName, userRole, userStatus);
                }
                else
                {
                    if (findPassOld.Rows[0][3].ToString() == userPassOld)
                        lu.updatePassAccount(userId, userPassNew, userPassOld);
                    else
                        MessageBox.Show("Mật khẩu cũ của bạn không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            
            if(!String.IsNullOrEmpty(userPassOld) && String.IsNullOrEmpty(userPassNew))
            {
                tbUserPassOld.Clear();
                tbUserPassNew.Clear();
                MessageBox.Show(GlobalData.msbUpdate, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbUserEmail_Enter(object sender, EventArgs e)
        {
            tbUserEmail.Clear();
        }

        private void tbUserPassOld_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cf.IsVietnameseCharacter(e.KeyChar))
            {
                // Chặn ký tự
                e.Handled = true;
            }
        }
    }
}
