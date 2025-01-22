using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLPhongMay_G4.editMiniModal;
using static QLPhongMay_G4.loginPortal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLPhongMay_G4
{
    internal class commonFormat
    {     
        public void checkPatternIn(System.Windows.Forms.TextBox textBox, string pattern)
        {
            string input = textBox.Text;
            //string pattern = @"^\d{2}/\d{2}/\d{4}$";
            if (!string.IsNullOrEmpty(textBox.Text))
                if (!Regex.IsMatch(input, pattern))
                {
                    MessageBox.Show(GlobalData.msbError, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Text = "";
                }
        }

        public void checkNumberCapacity(System.Windows.Forms.Control control)
        {
            if (int.TryParse(control.Text, out int value))
            {
                if (value < 1 || value > 100)
                {
                    MessageBox.Show("Vui lòng nhập một số từ 1 đến 100.");
                    control.Text = string.Empty; // Xóa nội dung không hợp lệ
                }
            }
        }

        public bool IsVietnameseCharacter(char c)
        {
            // Sử dụng Regex để kiểm tra các ký tự Unicode có dấu
            string pattern = "[àáạảãâầấậẩẫăằắặẳẵèéẹẻẽêềếệểễìíịỉĩòóọỏõôồốộổỗơờớợởỡùúụủũưừứựửữỳýỵỷỹđÀÁẠẢÃÂẦẤẬẨẪĂẰẮẶẲẴÈÉẸẺẼÊỀẾỆỂỄÌÍỊỈĨÒÓỌỎÕÔỒỐỘỔỖƠỜỚỢỞỠÙÚỤỦŨƯỪỨỰỬỮỲÝỴỶỸĐ]";
            return Regex.IsMatch(c.ToString(), pattern);
        }

        public void verifyDataCombobox(System.Windows.Forms.ComboBox ctr)
        {
            if (!ctr.Items.Contains(ctr.Text) && !string.IsNullOrEmpty(ctr.Text))
            {
                MessageBox.Show(GlobalData.msbError,
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                ctr.Text = string.Empty;
            }
        }

        public void openEditRequest(string RequestIdSelect)
        {
            GlobalData.selectedRequestId = RequestIdSelect;
            editRoomRequest eRR = new editRoomRequest();
            eRR.ShowDialog();
        }

        public void openEditMiniModal(string SelectID)
        {
            if (formOpenMiniModal.modal == "room")
                GlobalData.selectedRoomId = SelectID;
            if (formOpenMiniModal.modal == "device")
                GlobalData.selectedDeviceId = SelectID;
            if (formOpenMiniModal.modal == "account")
                GlobalData.selectedUserId = SelectID;

            editMiniModal eMM = new editMiniModal();
            eMM.ShowDialog();
        }
    }
}
