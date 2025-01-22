using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLPhongMay_G4
{
    public partial class loginPortal : Form
    {
        public loginPortal()
        {
            InitializeComponent();

            button1.BackColor = Color.FromName(GlobalData.colorButtonDone);

            this.AcceptButton = button1;
        }     

        loadUser logIn = new loadUser();
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            DataTable result = logIn.userAccountList(username, password);

            if (result.Rows.Count > 0)
            {
                // Lấy thông tin tài khoản
                GlobalData.dataUserRole = result.Rows[0][5].ToString();
                string userRole = GlobalData.dataUserRole;

                // Mở Form 2 và truyền thông tin tài khoản
                GlobalData.dataUserId = result.Rows[0][0].ToString();
                string userId = GlobalData.dataUserId;

                itRoomManagement form2 = new itRoomManagement();
                form2.Show();
                this.Hide(); // Ẩn Form 1
                //MessageBox.Show("Người dùng tồn tại!", "Thông báo");
            }
            else
            {
                MessageBox.Show(GlobalData.msbErrorSignIn, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public static class GlobalData
        {
            public static string dataUserId { get; set; }
            public static string dataUserRole { get; set; }
            public static string selectedUserId { get; set; }
            public static string selectedRequestId { get; set; }
            public static string selectedDeviceId { get; set; }
            public static string selectedRoomId { get; set; }
            public static string msbError { get; set; } = "Bạn vui lòng nhập đúng định dạng!";
            public static string msbErrorRoomRQ { get; set; } = "Phòng đang được sử dụng hoặc đang bảo trì!";
            public static string msbErrorRoomRQTime { get; set; } = "Phòng đang được sử dụng trong khoảng thời gian này!";
            public static string msbErrorTimeRQ { get; set; } = "Thời gian mượn phải tối thiểu là 1 giờ!";
            public static string msbErrorDateRQ { get; set; } = "Thời gian mượn phải trước tối thiểu là 1 ngày, tối đa là 3 ngày!";
            public static string msbErrorUser { get; set; } = "Không tìm thấy thông tin tài khoản!";
            public static string msbErrorSignIn { get; set; } = "Tài khoản hoặc mật khẩu không đúng, vui lòng nhập lại!";
            public static string msbKeypressFull { get; set; } = "Bạn vui lòng nhập đầy đủ trường dữ liệu!";
            public static string msbKeypress { get; set; } = "Bạn vui lòng nhập đúng định dạng hoặc chọn một giá trị từ danh sách!";
            public static string msbInsert { get; set; } = "Dữ liệu sẽ được thêm!";
            public static string msbInsertError { get; set; } = "Dữ liệu đã tồn tại!";
            public static string msbUpdate { get; set; } = "Dữ liệu của bạn sẽ được cập nhật lại!";
            public static string msbRemove { get; set; } = "Dữ liệu sẽ được xoá?";
            public static string msbOut { get; set; } = "Bạn có chắc chắn muốn thoát không?";
            public static string colorPrimary { get; set; } = "CadetBlue"; /* Màu chính */
            public static string colorSecondary1 { get; set; } = "DarkSlateGray"; /* Màu phụ */
            public static string colorSecondary2 { get; set; } = "DarkCyan"; /* Màu phụ */
            public static string colorHightlight { get; set; } = "Highlight"; /* Màu phụ */
            public static string colorBackground { get; set; } = "SlateGray"; /* Màu nền */
            public static string colorText { get; set; } = "White"; /*Màu chữ chính */
            public static string colorButtonDis { get; set; } = "LightSlateGray"; /* Màu nút */
            public static string colorButtonDone { get; set; } = "SeaGreen"; /* Màu nút */
            public static string colorButtonEdit { get; set; } = "Orange"; /* Màu nút */
            public static string colorButtonUpdate { get; set; } = "MidnightBlue"; /* Màu nút */
            //Cach goi mau FromName(GlobalData.primaryColor);
        }

        private void btnShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';

        }

        private void btnShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '⬤';

        }
    }
}
