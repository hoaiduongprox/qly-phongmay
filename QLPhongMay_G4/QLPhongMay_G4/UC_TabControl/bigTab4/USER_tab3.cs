using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLPhongMay_G4.editMiniModal;
using static QLPhongMay_G4.loginPortal;

namespace QLPhongMay_G4.UC_TabControl.bigTab4
{
    public partial class USER_tab3 : UserControl
    {
        public USER_tab3()
        {
            formOpenMiniModal.modal = "account";
            InitializeComponent();

            cbUserRole.Items.Add("Người đăng ký");
            cbUserRole.Items.Add("Quản lý");
            cbUserRole.Items.Add("Quản trị");

            btnFind.BackColor = Color.FromName(GlobalData.colorButtonDone);

            EventManager.ButtonClicked += btnFind_Click;
        }

        commonFormat cf = new commonFormat();
        loadUser lu = new loadUser();

        void loadInforAccount(DataTable dt)
        {
            listView1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {                
                ListViewItem lvi =
                listView1.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                btnFind.BackColor = Color.FromName(GlobalData.colorButtonDone);


                string roleIn = dt.Rows[i][5].ToString();
                string roleOut = "";

                if (roleIn == "admin")
                    roleOut = "Quản trị";
                else if (roleIn == "manager")
                    roleOut = "Quản lý";
                else
                    roleOut = "Người đăng ký";

                lvi.SubItems.Add(roleOut);

                string status = "";
                if (dt.Rows[i][6].ToString() == "True")
                    status = "Hoạt động";
                else
                    status = "Đã đóng";

                lvi.SubItems.Add(status);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string UserId = tbUserId.Text;
            string roleIn = cbUserRole.Text;

            byte roleOut = 3;

            if (roleIn == "Quản trị")
                roleOut = 2;
            if (roleIn == "Quản lý")
                roleOut = 1;
            if (roleIn == "Người đăng ký")
                roleOut = 0;

            DataTable dt = lu.findUserID(UserId, roleOut);
            loadInforAccount(dt);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string UserIdSelected = listView1.SelectedItems[0].SubItems[0].Text;
            cf.openEditMiniModal(UserIdSelected);
        }

        private void tbUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và phím Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void cbUserRole_Validating(object sender, CancelEventArgs e)
        {
            cf.verifyDataCombobox(cbUserRole);
        }
    }
}
