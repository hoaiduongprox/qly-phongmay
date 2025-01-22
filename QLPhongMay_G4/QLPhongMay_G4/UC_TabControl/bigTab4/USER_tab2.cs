using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLPhongMay_G4.loginPortal;

namespace QLPhongMay_G4.UC_TabControl.bigTab4
{
    public partial class USER_tab2 : UserControl
    {
        public USER_tab2()
        {
            InitializeComponent();

            cbUserRole.Text = "Người đăng ký";
            tbUserPassNew.PasswordChar = '⬤';
            btnAddAccount.BackColor = Color.FromName(GlobalData.colorButtonDone);

        }

        string AccountID = GlobalData.dataUserId;
        commonFormat cf = new commonFormat();
        loadUser lu = new loadUser();
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userId = tbUserId.Text;
            string userMail = tbUserEmail.Text;
            string fullName = tbFullName.Text;
            string userPassNew = tbUserPassNew.Text;

            DialogResult result = MessageBox.Show(GlobalData.msbInsert, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lu.insertAccount(userId, fullName, userMail, userPassNew);
                tbUserId.Clear();
                tbUserEmail.Clear();
                tbFullName.Clear();
                tbUserPassNew.Clear();
            }
        }

        private void tbUserEmail_Leave(object sender, EventArgs e)
        {
            string pattern = emailPattern;
            cf.checkPatternIn(tbUserEmail, pattern);
        }

        private void btnShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            tbUserPassNew.PasswordChar = '\0';
        }

        private void btnShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            tbUserPassNew.PasswordChar = '⬤';
        }

        private void tbUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và phím Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void tbUserPassNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cf.IsVietnameseCharacter(e.KeyChar))
            {
                // Chặn ký tự
                e.Handled = true;
            }
        }
    }
}
