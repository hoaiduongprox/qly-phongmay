using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLPhongMay_G4.loginPortal;

namespace QLPhongMay_G4.controllers
{
    internal class loadDevice
    {
        database db;
        public loadDevice()
        {
            db = new database();
        }

        string getDeviceTypeENG(string index_deviceType)
        {
            string getDeviceType = index_deviceType;
            if (index_deviceType == "Màn hình")
                getDeviceType = "Monitor";
            if (index_deviceType == "Chuột vi tính")
                getDeviceType = "Mouse";
            if (index_deviceType == "Bàn phím")
                getDeviceType = "Keyboard";
            if (index_deviceType == "Thùng máy")
                getDeviceType = "Tower";
            if (index_deviceType == "Máy in")
                getDeviceType = "Printer";

            return getDeviceType;
        }

        public string getDeviceTypeVIE(string index_deviceType)
        {
            string getDeviceType = index_deviceType;
            if (index_deviceType == "Monitor")
                getDeviceType = "Màn hình";
            if (index_deviceType == "Mouse")
                getDeviceType = "Chuột vi tính";
            if (index_deviceType == "Keyboard")
                getDeviceType = "Bàn phím";
            if (index_deviceType == "Tower")
                getDeviceType = "Thùng máy";
            if (index_deviceType == "Printer")
                getDeviceType = "Máy in";

            return getDeviceType;
        }

        DataTable countDeviceInRoom(string index_roomId)
        {
            string strSQL = string.Format("SELECT deviceType, " +
                "COUNT(*) AS deviceCount " +
                "FROM DEVICE " +
                "WHERE roomId = @roomId " +
                "GROUP BY roomId, deviceType");
            SqlCommand command = new SqlCommand(strSQL);
            command.Parameters.AddWithValue("@roomId", index_roomId);
            //command.Parameters.AddWithValue("@deviceStatus", index_status);
            DataTable dt = db.Execute(command);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }

        public string stringCountDeviceInRoom(string index_roomId)
        {
            DataTable countDIR = countDeviceInRoom(index_roomId);

            byte[] countD = new byte[countDIR.Rows.Count];

            byte j = 0;
            foreach (DataRow row in countDIR.Rows)
            {
                countD[j] = byte.Parse(row[1].ToString());
                j++;
            }

            string format = $"Bàn phím: {countD.ElementAtOrDefault(0)} | Màn hình: {countD.ElementAtOrDefault(1)} | Chuột vi tính: {countD.ElementAtOrDefault(2)} | Máy in: {countD.ElementAtOrDefault(3)} | Thùng máy: {countD.ElementAtOrDefault(4)}";

            return format;
        }


        public DataTable inforDevice(string index_deviceId, string index_roomId, string index_deviceName, string index_deviceType, byte index_status)
        {
            string getDeviceType = getDeviceTypeENG(index_deviceType);

            string strSQL = string.Format("SELECT " +
                "D.deviceId," +
                "D.deviceName, " +
                "D.deviceType, " +
                "D.deviceStatus, " +
                "D.deviceErrorNote, " +
                "D.roomId " +
                "FROM " +
                "DEVICE D, " +
                "ROOM R " +
                "WHERE " +
                "D.roomId = R.roomId");

            if (!string.IsNullOrEmpty(index_deviceId))
                strSQL += " AND @deviceId = D.deviceId";

            if (!string.IsNullOrEmpty(index_roomId))
                strSQL += " AND @roomId = D.roomId";

            if (!string.IsNullOrEmpty(index_deviceName))
                strSQL += " AND @deviceName = D.deviceName"; //Vi day la truong hop bat dat di nen se thay the cho ID

            if (!string.IsNullOrEmpty(index_deviceType))
                strSQL += " AND @deviceType = D.deviceType";
            
            if (index_status == 1)
                strSQL += " AND D.deviceStatus = 1";

            if (index_status == 0)
                strSQL += " AND D.deviceStatus = 0";

            SqlCommand command = new SqlCommand(strSQL);
            command.Parameters.AddWithValue("@deviceId", index_deviceId);
            command.Parameters.AddWithValue("@roomId", index_roomId);
            command.Parameters.AddWithValue("@deviceName", index_deviceName);
            command.Parameters.AddWithValue("@deviceType", getDeviceType);
            //command.Parameters.AddWithValue("@deviceStatus", index_status);
            DataTable dt = db.Execute(command);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }

        public void loadCBDataDevice(System.Windows.Forms.ComboBox comboBox, byte colAdd)
        {
            string[] items = { "Màn hình", "Chuột vi tính", "Bàn phím", "Thùng máy", "Máy in" };
            comboBox.Items.AddRange(items);
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend; //Thuộc tính này xác định cách thức ComboBox gợi ý và hoàn chỉnh các mục trong danh sách khi người dùng nhập văn bản.
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;//Thuộc tính này xác định nguồn dữ liệu mà ComboBox sử dụng để gợi ý và tự động hoàn chỉnh.
        }

        public void insertDevice(string index_deviceName, string index_deviceType, bool index_deviceStatus,
            string index_deviceErrorNote, string index_roomId)
        {
            string getDErrorNote = "";
            if (index_deviceStatus == false)
                getDErrorNote = index_deviceErrorNote;

            string getDeviceType = getDeviceTypeENG(index_deviceType);

            string sql = string.Format("INSERT INTO DEVICE " +
                "Values('{0}', '{1}', '{2}', N'{3}', '{4}')",
                index_deviceName, getDeviceType, index_deviceStatus, getDErrorNote, index_roomId);
            db.ExecuteNonQuery(sql);          
        }

        public bool checkEmpty(byte checkInsert, string index_deviceName, string index_deviceType, 
            bool index_deviceStatus, string index_roomId)
        {
            if (string.IsNullOrEmpty(index_deviceName) 
                || string.IsNullOrEmpty(index_deviceType)
                || string.IsNullOrEmpty(index_deviceStatus.ToString()) 
                || string.IsNullOrEmpty(index_roomId))
                MessageBox.Show(GlobalData.msbKeypressFull, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                if (inforDevice("", index_roomId, index_deviceName, index_deviceType, 3).Rows.Count > 0 && checkInsert == 1)
                    MessageBox.Show(GlobalData.msbInsertError, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    return true;
            return false;
        }

        public void updateInforDevice(string index_deviceId, byte index_deviceSTT, string index_deviceType, bool index_deviceStatus, string index_deviceErrorNote, string index_roomId)
        {
            string getDeviceType = getDeviceTypeENG(index_deviceType);
            string getSTT = index_deviceSTT.ToString();

            if (checkEmpty(0, getSTT, index_deviceType, index_deviceStatus, index_roomId))
            {
                string str = string.Format("UPDATE DEVICE " +
                    "SET " +
                    "deviceName = '{0}', " +
                    "deviceType = '{1}', " +
                    "deviceStatus = '{2}', " +
                    "deviceErrorNote = N'{3}', " +
                    "roomId = '{4}'" +
                    "WHERE " +
                    "deviceId = {5}" , index_deviceSTT, getDeviceType, index_deviceStatus, index_deviceErrorNote, index_roomId, index_deviceId);

                db.ExecuteNonQuery(str);
            }
        }

        public void removeDevice(byte index_deviceSTT, string index_deviceType, string index_roomId)
        {
            string getDeviceType = getDeviceTypeENG(index_deviceType);

            string sql = string.Format("DELETE " +
                "FROM " +
                "DEVICE " +
                "WHERE " +
                "deviceName = {0} " +
                "AND deviceType = '{1}'" +
                "AND roomId = '{2}'", index_deviceSTT, getDeviceType, index_roomId);

            db.ExecuteNonQuery(sql);
        }
    }
}
