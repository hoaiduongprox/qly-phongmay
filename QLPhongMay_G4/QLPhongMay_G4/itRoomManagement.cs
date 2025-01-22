using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using QLPhongMay_G4.UC_TabControl;
using QLPhongMay_G4.UC_TabControl.bigTab2;
using QLPhongMay_G4.UC_TabControl.bigTab3;
using QLPhongMay_G4.UC_TabControl.bigTab4;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static QLPhongMay_G4.loginPortal;

namespace QLPhongMay_G4
{
    public partial class itRoomManagement : Form
    {

        public itRoomManagement()
        {
            InitializeComponent();            

            ITRM_tab1 iTRM_tab = new ITRM_tab1();
            addUserControl(iTRM_tab);

            ///Giá trị khởi tạo ban đầu
            panel1.BackColor = Color.FromName(GlobalData.colorPrimary);
            panel2.BackColor = Color.FromName(GlobalData.colorSecondary1);
            panel3.BackColor = Color.FromName(GlobalData.colorButtonDone);


            //Các tab lớn
            btnBigTab1.Click += bigTab_Click;
            btnBigTab2.Click += bigTab_Click;
            btnBigTab3.Click += bigTab_Click;
            btnBigTab4.Click += bigTab_Click;
            SetActiveBigTab(btnBigTab1);


            //Các tab con
            btnTab1.Click += Tab_Click;
            DisableButtonColors(btnTab1);
            btnTab2.Click += Tab_Click;
            DisableButtonColors(btnTab2);
            btnTab3.Click += Tab_Click;
            DisableButtonColors(btnTab3);
            SetActiveTab(btnTab1);

            //Giá trị khởi tạo nút
            btnTab1.Visible = true;
            btnTab1.Text = "Tra cứu";
            btnTab2.Visible = true;
            btnTab2.Text = "Đơn duyệt phòng";
            btnTab3.Visible = false;
            sttTab1 = true;


            RestrictAccess(accountID, accountRole);
        }

        string accountID = GlobalData.dataUserId;
        string accountRole = GlobalData.dataUserRole;
        loadUser lu = new loadUser();

        void RestrictAccess(string userId, string role)
        {
            DataTable dt = lu.findUserID(userId, 3);

            if (dt.Rows.Count > 0)
            {
                lbNameUser.Text = dt.Rows[0][4].ToString();

                if (role == "admin")
                {
                    lbRoleUser.Text = "Quản trị";
                    lbRoleUser.BackColor = Color.Red;

                }
                else if (role == "manager")
                {
                    lbRoleUser.Text = "Quản lý";
                    lbRoleUser.BackColor = Color.FromName(GlobalData.colorHightlight);


                }
                else
                {
                    lbRoleUser.Text = "Người đăng ký";
                    lbRoleUser.BackColor = Color.FromName(GlobalData.colorSecondary2);


                    btnBigTab3.Visible = false;
                    btnBigTab4.Location = new Point(0, 376);
                    //btn
                }
            }            
        }

        public void OpenForm3()
        {
            // Tạo instance của Form3
            editRoomRequest form3 = new editRoomRequest();

            // Disable Form2
            this.Enabled = false;

            // Xử lý sự kiện FormClosed để enable lại Form2
            form3.FormClosed += (s, args) =>
            {
                this.Enabled = true; // Enable lại Form2 khi Form3 đóng
            };

            // Hiển thị Form3
            form3.Show();
        }

        bool sttTab1 = false;
        bool sttTab2 = false;
        bool sttTab3 = false;
        bool sttTab4 = false;

        private void bigTab_Click(object sender, EventArgs e)
        {
            // Đặt tab đang hoạt động
            btnTab1.Visible = false;
            btnTab2.Visible = false;
            btnTab3.Visible = false;

            sttTab1 = false;
            sttTab2 = false;
            sttTab3 = false;
            sttTab4 = false;
            btnTab1.Font = new Font(btnTab1.Font, FontStyle.Regular);
            btnTab2.Font = new Font(btnTab1.Font, FontStyle.Regular);
            btnTab3.Font = new Font(btnTab1.Font, FontStyle.Regular);

            System.Windows.Forms.Button clickedTab = sender as System.Windows.Forms.Button;
            if (clickedTab != null)
            {
                SetActiveBigTab(clickedTab);

                // Hiển thị nội dung tương ứng với tab
                if (clickedTab == btnBigTab1)
                {
                    ITRM_tab1 iTRM_tab = new ITRM_tab1();
                    addUserControl(iTRM_tab);

                    btnTab1.Visible = true;
                    btnTab1.Text = "Tra cứu";

                    btnTab2.Visible = true;
                    btnTab2.Text = "Đơn duyệt phòng";

                    sttTab1 = true;
                    btnTab1.Font = new Font(btnTab1.Font, FontStyle.Bold);
                }
                else if (clickedTab == btnBigTab2)
                {
                    ROOM_tab1 room_tab = new ROOM_tab1();
                    addUserControl(room_tab);
                    sttTab2 = true;
                }
                else if (clickedTab == btnBigTab3)
                {
                    DEVICE_tab1 device_tab = new DEVICE_tab1();
                    addUserControl(device_tab);
                    sttTab3 = true;
                }
                else if (clickedTab == btnBigTab4)
                {
                    USER_tab1 user_tab = new USER_tab1();
                    addUserControl(user_tab);

                    btnTab1.Visible = true;
                    btnTab1.Text = "Cập nhật";
                    btnTab1.Font = new Font(btnTab1.Font, FontStyle.Bold);

                    if (accountRole == "admin")
                    {
                        btnTab2.Visible = true;
                        btnTab2.Text = "Thêm tài khoản";

                        btnTab3.Visible = true;
                        btnTab3.Text = "Tra cứu";
                    }
                    sttTab4 = true;
                }
            }
        }

        private void SetActiveBigTab(System.Windows.Forms.Button activeTab)
        {
            // Reset màu của tất cả các tab về mặc định
            btnBigTab1.BackColor = Color.FromName(GlobalData.colorSecondary1);
            btnBigTab2.BackColor = btnBigTab1.BackColor;
            btnBigTab3.BackColor = btnBigTab1.BackColor;
            btnBigTab4.BackColor = btnBigTab1.BackColor;

            // Đặt màu cho tab đang được chọn
            activeTab.BackColor = Color.FromName(GlobalData.colorPrimary); // Màu cho tab đang hoạt động
        }

        private void DisableButtonColors(System.Windows.Forms.Button button)
        {
            // Đặt màu nền trong suốt (hoặc một màu cụ thể)
            button.BackColor = Color.Transparent;

            // Đặt màu chữ (tùy ý, ở đây là đen)
            //button.ForeColor = Color.;

            // Loại bỏ viền và hiệu ứng focus
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0; // Viền bằng 0
            button.FlatAppearance.MouseOverBackColor = Color.Transparent; // Không màu khi hover
            button.FlatAppearance.MouseDownBackColor = Color.Transparent; // Không màu khi click
            button.FlatAppearance.CheckedBackColor = Color.Transparent; // Không màu khi checked
        }


        private void Tab_Click(object sender, EventArgs e)
        {
            // Đặt tab đang hoạt động
            System.Windows.Forms.Button clickedTab = sender as System.Windows.Forms.Button;
            if (clickedTab != null)
            {
                SetActiveTab(clickedTab);

                // Hiển thị nội dung tương ứng với tab
                if (clickedTab == btnTab1)
                {
                    if (sttTab1 == true)
                    {
                        ITRM_tab1 iTRM_tab = new ITRM_tab1();
                        addUserControl(iTRM_tab);
                    }

                    if (sttTab4 == true)
                    {
                        USER_tab1 USER_tab = new USER_tab1();
                        addUserControl(USER_tab);
                    }
                }
                else if (clickedTab == btnTab2)
                {
                    if (sttTab1 == true)
                    {
                        ITRM_tab2 iTRM_tab = new ITRM_tab2();
                        addUserControl(iTRM_tab);
                    }

                    if (sttTab4 == true)
                    {
                        USER_tab2 USER_tab = new USER_tab2();
                        addUserControl(USER_tab);
                    }
                }
                else if (clickedTab == btnTab3)
                {
                    if (sttTab4 == true)
                    {
                        USER_tab3 USER_tab = new USER_tab3();
                        addUserControl(USER_tab);
                    }
                }
            }
        }

        private void SetActiveTab(System.Windows.Forms.Button activeTab)
        {
            // Reset màu của tất cả các tab về mặc định
            btnTab1.Font = new Font(btnTab1.Font, FontStyle.Regular);
            btnTab2.Font = new Font(btnTab1.Font, FontStyle.Regular);
            btnTab3.Font = new Font(btnTab1.Font, FontStyle.Regular);

            // Đặt màu cho tab đang được chọn
            activeTab.Font = new Font(btnTab1.Font, FontStyle.Bold);
        }


        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void lbRoleUser_DoubleClick(object sender, EventArgs e)
        {
            loginPortal loginPortal = new loginPortal();
            loginPortal.Show();
            this.Close();
        }
    }
}
