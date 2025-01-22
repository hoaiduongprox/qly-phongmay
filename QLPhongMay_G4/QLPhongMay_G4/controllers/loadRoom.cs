using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongMay_G4.controllers;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static QLPhongMay_G4.loginPortal;

namespace QLPhongMay_G4
{
    internal class loadRoom
    {
        database db;
        public loadRoom()
        {
            db = new database();
        }

        public DataTable inforRoom(string index_roomId, byte index_Status, string index_Capacity)
        {
            string strSQL = "SELECT * " +
                "FROM ROOM " +
                "WHERE " +
                "NOT roomId = ''";

            //if (!string.IsNullOrEmpty(index_roomId) || !string.IsNullOrEmpty(index_Status) || !string.IsNullOrEmpty(index_Capacity))
            //    strSQL += " WHERE";

            if (!string.IsNullOrEmpty(index_roomId))
                strSQL += " AND @roomId = roomId";


            //strSQL += " AND @roomStatus = roomStatus";
            if (index_Status >= 0 && index_Status <= 2)
                switch (index_Status)
                {
                    case 0: strSQL += " AND 'free' = roomStatus"; break;
                    case 1: strSQL += " AND  'inuse' = roomStatus"; break; //Đang sử dụng
                    case 2: strSQL += " AND  'maintenance' = roomStatus"; break; //Bảo trì
                }


            if (!string.IsNullOrEmpty(index_Capacity))
                strSQL += " AND @roomCapacity = roomCapacity";

            SqlCommand command = new SqlCommand(strSQL);
            command.Parameters.AddWithValue("@roomId", index_roomId);
            //command.Parameters.AddWithValue("@roomStatus", index_Status);
            command.Parameters.AddWithValue("@roomCapacity", index_Capacity);
            DataTable dt = db.Execute(command);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }

        public void loadCBDataRoom(System.Windows.Forms.ComboBox comboBox, byte colAdd)
        {
            DataTable dt = inforRoom("", 3, "");
            var comboBoxItems = new HashSet<string>(); // Sử dụng HashSet để loại bỏ giá trị trùng
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //cbRoomId.Items.Add(dt.Rows[i][0]);
                comboBoxItems.Add(dt.Rows[i][colAdd].ToString());

            }
            comboBox.Items.Clear();
            foreach (var item in comboBoxItems.OrderBy(item => item))
            {
                comboBox.Items.Add(item);
            }

            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend; //Thuộc tính này xác định cách thức ComboBox gợi ý và hoàn chỉnh các mục trong danh sách khi người dùng nhập văn bản.
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;//Thuộc tính này xác định nguồn dữ liệu mà ComboBox sử dụng để gợi ý và tự động hoàn chỉnh.
        }

        public void insertRoom(string index_roomId, string index_roomName, byte index_roomStatus,
            string index_roomErrorNote, string index_roomCapacity)
        {
            string getStatus = getRoomStatus(index_roomStatus);

            string sql = string.Format("INSERT INTO ROOM " +
                "Values('{0}', N'{1}', '{2}', N'{3}', '{4}')",
                index_roomId, index_roomName, getStatus, index_roomErrorNote, index_roomCapacity);
            db.ExecuteNonQuery(sql);
        }

        public void removeRoom(string index_roomId)
        {
            string sql = string.Format("DELETE " +
                "FROM " +
                "ROOM " +
                "WHERE " +
                "roomId = '{0}'", index_roomId);

            db.ExecuteNonQuery(sql);
        }

        public bool checkEmpty(byte checkInsert, string index_roomId, string index_roomName, byte index_roomStatus, string index_roomCapacity)
        {
            if (!string.IsNullOrEmpty(index_roomId) && !string.IsNullOrEmpty(index_roomName) && !string.IsNullOrEmpty(index_roomStatus.ToString())
                && !string.IsNullOrEmpty(index_roomCapacity))
                if (inforRoom(index_roomId, 3, "").Rows.Count > 0 && checkInsert == 1)
                    MessageBox.Show(GlobalData.msbInsertError, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    return true;
            else
                MessageBox.Show(GlobalData.msbKeypressFull, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        string getRoomStatus(byte index_roomStatus)
        {
            string getStatus = index_roomStatus.ToString();
            if (index_roomStatus >= 0 && index_roomStatus <= 2)
                switch (index_roomStatus)
                {
                    case 0: getStatus = "free"; break;
                    case 1: getStatus = "inuse"; break; //Đang sử dụng
                    case 2: getStatus = "maintenance"; break; //Bảo trì
                }
            return getStatus;
        }

        public void updateInforRoom(string index_roomId, string index_roomName, byte index_roomStatus, 
            string index_roomErrorNote, string index_roomCapacity)
        {
            string getStatus = getRoomStatus(index_roomStatus);

            if (checkEmpty(0, index_roomId, index_roomName, index_roomStatus, index_roomCapacity))
            {
                string str = string.Format("UPDATE ROOM " +
                    "SET " +
                    "roomName = N'{1}', " +
                    "roomStatus = '{2}', " +
                    "roomErrorNote = N'{3}', " +
                    "roomCapacity = '{4}' " +
                    "WHERE " +
                    "roomId = '{0}'", index_roomId, index_roomName, getStatus, index_roomErrorNote, index_roomCapacity);

                db.ExecuteNonQuery(str);
            }          
        }
    }
}