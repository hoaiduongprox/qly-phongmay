using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLPhongMay_G4.loginPortal;
using System.Globalization;

namespace QLPhongMay_G4
{
    internal class loadUser
    {
        database db;
        public loadUser()
        {
            db = new database();
        }

        public DataTable userAccountList(string index_account, string index_password)
        {
            string strSQL = "SELECT * FROM USER_ACCOUNT WHERE userStatus = 1 AND userID = @account AND userPass = @password";

            // Tạo SqlCommand với tham số
            SqlCommand command = new SqlCommand(strSQL);
            command.Parameters.AddWithValue("@account", index_account);
            command.Parameters.AddWithValue("@password", index_password);

            // Gọi phương thức truy vấn với command
            DataTable dt = db.Execute(command);
            return dt;
        }

        public DataTable findUserID(string index_userId, byte index_userRole)
        {
            string getRole = "";

            if (index_userRole == 0)
                getRole = "user";
            if (index_userRole == 1)
                getRole = "manager";
            if (index_userRole == 2)
                getRole = "admin";

            string strSQL = string.Format("SELECT " +
                "userId, " +
                "userName, " +
                "userMail, " +
                "userPass, " +
                "fullName, " +
                "userRole, " +
                "userStatus " +
                "FROM " +
                "USER_ACCOUNT " +
                "WHERE " +
                "NOT userId = ''");

            // Thêm điều kiện lọc dựa trên tham số đầu vào

            if (!string.IsNullOrEmpty(index_userId))
                strSQL += " AND userId = @userId";

            if (index_userRole >= 0 && index_userRole <= 2)
                strSQL += " AND userRole = @userRole";

            /////////////////////////////////Tai WHERE phai nam tren nhung luc minh them lenh vao Where thi xung dot
            strSQL += " ORDER BY userRole ASC";
            ///


            SqlCommand command = new SqlCommand(strSQL);
            command.Parameters.AddWithValue("@userId", index_userId);
            command.Parameters.AddWithValue("@userRole", getRole);

            DataTable dt = db.Execute(command);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }

        public void updateInforAccount(string index_userId, string index_userMail, 
            string index_fullName, byte index_userRole, 
            byte index_userStatus)
        {
            string getName = GetLastNameWithoutDiacritics(index_fullName);
            string getNameMSSV = getName + index_userId;
            string getRole = index_userRole == 1 ? "manager" : index_userRole == 2 ? "admin" : "user";
                     
            string str = string.Format("UPDATE USER_ACCOUNT " +
                "SET " +
                "userMail = '{2}', " +
                "userName = '{1}', " +
                "fullName = N'{3}', " +
                "userRole = '{4}', " +
                "userStatus = {5} " +
                "WHERE " +
                "userId = '{0}'", index_userId, getNameMSSV, index_userMail, 
                index_fullName, getRole, index_userStatus);

            db.ExecuteNonQuery(str);
        }

        public void updatePassAccount(string index_userId, string index_PassNew, string index_PassOld)
        {
            string str = string.Format("UPDATE USER_ACCOUNT " +
                "SET " +
                "userPass = '{1}' " +
                "WHERE " +
                "userId = '{0}' AND " +
                "userPass = '{2}'", index_userId, index_PassNew, index_PassOld);

            db.ExecuteNonQuery(str);
        }

        //cha
        static string GetLastNameWithoutDiacritics(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                return string.Empty; // Trả về chuỗi rỗng nếu tên không hợp lệ
            }

            // Tách tên (lấy phần cuối cùng sau dấu cách)
            string[] parts = fullName.Trim().Split(' ');
            string lastName = parts[parts.Length - 1];

            // Loại bỏ dấu
            return RemoveAccents(lastName);
        }

        //con
        static string RemoveAccents(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            string normalizedText = text.Normalize(NormalizationForm.FormD);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in normalizedText)
            {
                UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        public void insertAccount(string index_userId, string index_fullName, string index_email, 
            string index_PassNew)
        {
            string getName = GetLastNameWithoutDiacritics(index_fullName);
            string getNameMSSV = getName + index_userId;

            if (checkEmpty(index_userId, index_fullName, index_email, index_PassNew))
            {
                string sql = string.Format("INSERT INTO USER_ACCOUNT " +
                    "Values('{0}', '{1}', '{2}', '{3}', N'{4}', 'user', 0)",
                    index_userId, getNameMSSV, index_email, index_PassNew, index_fullName);
                db.ExecuteNonQuery(sql);
            }
        }

        public bool checkEmpty(string index_userId, string index_fullName,
            string index_email, string index_PassNew)
        {
            if (!string.IsNullOrEmpty(index_userId) && !string.IsNullOrEmpty(index_fullName)
                && !string.IsNullOrEmpty(index_email) && !string.IsNullOrEmpty(index_PassNew))
                if (findUserID(index_userId, 3).Rows.Count > 0)
                    MessageBox.Show(GlobalData.msbInsertError, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    return true;
            else
                MessageBox.Show(GlobalData.msbKeypressFull, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            return false;
        }

        public void removeAccount(string index_userId)
        {
            string sql = string.Format("DELETE " +
                "FROM " +
                "USER_ACCOUNT " +
                "WHERE " +
                "userId = '{0}'", index_userId);

            db.ExecuteNonQuery(sql);
        }
    }
}