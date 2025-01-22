using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QLPhongMay_G4.loginPortal;
using System.Windows.Forms;
using System.Globalization;

namespace QLPhongMay_G4.controllers
{
    internal class loadRequestRoom
    {
        database db;
        public loadRequestRoom()
        {
            db = new database();
        }

        public DataTable findRequestRoom(string index_roomId, string index_capacity, string index_UsageDate, 
            string index_StartTime, string index_EndTime, byte index_UsageOccupied, string index_userId)
        {
            string strSQL = string.Format("SELECT " +
                "R.roomId, " +
                "RQR.requestReason, " +
                "R.roomCapacity, " +
                "RQR.requestDate, " +
                "RQR.requestStartTime, " +
                "RQR.requestEndTime, " +
                "RQR.requestStatus, " +
                "UA.fullName, " +
                "RQR.requestId " +//Test
                "FROM " +
                "REQUEST_ROOM RQR, " +
                "USER_ACCOUNT UA, " +
                "USAGE_LIST UL, " +
                "ROOM R " +
                "WHERE " +
                "UA.userId = UL.userId AND " +
                "RQR.roomId = R.roomId AND " +
                "RQR.requestStatus = 1 AND " +
                "RQR.requestId = UL.requestId");

            // Thêm điều kiện lọc dựa trên tham số đầu vào
            if (!string.IsNullOrEmpty(index_roomId))
                strSQL += " AND R.roomId LIKE @roomIdPre";

            if (!string.IsNullOrEmpty(index_capacity))
                strSQL += " AND R.roomCapacity = @capacity";
                        
            if (!string.IsNullOrEmpty(index_UsageDate))
                strSQL += " AND RQR.requestDate = @usageDate";

            if (!string.IsNullOrEmpty(index_StartTime))
                strSQL += " AND RQR.requestStartTime = @startTime";

            if (!string.IsNullOrEmpty(index_EndTime))
                strSQL += " AND RQR.requestEndTime = @endTime";

            if (!string.IsNullOrEmpty(index_userId))
                strSQL += " AND RQR.userId = @userId";

            if (index_UsageOccupied != 0)
                strSQL += " AND UL.usageOccupied = 1";

            /////////////////////////////////Tai WHERE phai nam tren nhung luc minh them lenh vao Where thi xung dot
            strSQL += " ORDER BY RQR.requestDate ASC, RQR.requestStartTime ASC";
            ///


            SqlCommand command = new SqlCommand(strSQL);
            command.Parameters.AddWithValue("@roomIdPre", index_roomId + "%");
            command.Parameters.AddWithValue("@capacity", index_capacity);
            command.Parameters.AddWithValue("@userId", index_userId);

            if (DateTime.TryParseExact(index_UsageDate, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDateNew))
                command.Parameters.AddWithValue("@usageDate", parsedDateNew);

            command.Parameters.AddWithValue("@startTime", index_StartTime);
            command.Parameters.AddWithValue("@endTime", index_EndTime);

            DataTable dt = db.Execute(command);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }

        public DataTable loadInforRequests(string requestId, string userId)
        {
            string strSQL = "SELECT " +
                "RQR.userId, " +//
                "UA.fullName, " +//7--1
                "R.roomId, " +//0--2
                "R.roomName, " +//
                "R.roomCapacity, " +//2--4
                "RQR.requestDate, " +//3--5
                "RQR.requestStartTime, " +//4--6
                "RQR.requestEndTime, " +//5--7
                "RQR.requestReason, " +//1--8
                "RQR.adminNote, " +//8--9
                "RQR.requestStatus, " +//9--10
                "RQR.requestId " +//6--11
                "FROM " +
                "REQUEST_ROOM RQR, " +
                "USER_ACCOUNT UA, " +
                "ROOM R " +
                "WHERE " +
                "UA.userId = RQR.userId AND " +
                "RQR.roomId = R.roomId";

            // Nếu requestId = "0", lấy tất cả các request
            if (!string.IsNullOrEmpty(requestId))
                strSQL += " AND RQR.requestId = @requestId";
            else
                strSQL += " AND RQR.requestStatus = 0";

            
            if (!string.IsNullOrEmpty(userId))
                strSQL += " AND RQR.userId = @userId";


            strSQL += " ORDER BY RQR.requestDate ASC, RQR.requestStartTime ASC";

            SqlCommand command = new SqlCommand(strSQL);
            command.Parameters.AddWithValue("@requestId", requestId);
            command.Parameters.AddWithValue("@userId", userId);
            

            DataTable dt = db.Execute(command);
            return dt;
        }

        string dateFormatSQL = "MM/dd/yyyy";
        string dateFormat = "dd/MM/yyyy";
        public void insertSignUpRoom(string requestDate, string requestReason,
            byte requestStatus, string adminNote, string inUserId,
            string roomId, string requestStartTime, string requestEndTime)
        {            
            if (DateTime.TryParseExact(requestDate, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDateNew))
            {
                string StrDateNew = parsedDateNew.ToString(dateFormatSQL);

                string sql = string.Format("INSERT INTO REQUEST_ROOM " +
                "Values('{0}', N'{1}', {2}, N'{3}', '{4}', '{5}', '{6}', '{7}')", StrDateNew, requestReason, requestStatus, adminNote, inUserId,
                roomId, requestStartTime, requestEndTime);
                db.ExecuteNonQuery(sql);
            }
        }

        loadRoom lr = new loadRoom();
        
        public void updateRoomStatusUsing()
        {
            string str = string.Format("UPDATE ROOM " +
                    "SET roomStatus = CASE " +
                    "WHEN roomId IN (" +
                        "SELECT DISTINCT r.roomId  " +
                        "FROM REQUEST_ROOM r " +
                        "INNER JOIN USAGE_LIST u " +
                            "ON r.requestId = u.requestId " +
                        "WHERE u.usageOccupied = 1 " +
                        ") THEN 'inuse' " +
                        "ELSE 'free'" +
                        "END"); // Đóng ngoặc bị thiếu
            db.ExecuteNonQuery(str);
        }


        public bool checkEmpty(byte checkInsert, string requestDate, string requestReason, string inUserId,
        string roomId, string requestStartTime, string requestEndTime)
        {
            try
            {
                // Kiểm tra các thông tin cơ bản không được để trống
                if (string.IsNullOrEmpty(requestDate) || string.IsNullOrEmpty(requestReason) ||
                    string.IsNullOrEmpty(inUserId) || string.IsNullOrEmpty(roomId) ||
                    string.IsNullOrEmpty(requestStartTime) || string.IsNullOrEmpty(requestEndTime))
                {
                    MessageBox.Show(GlobalData.msbKeypressFull, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Định dạng và chuyển đổi chuỗi thành kiểu DateTime
                string timeFormat = "HH:mm";

                if (!DateTime.TryParseExact(requestStartTime, timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dtStartTime) ||
                    !DateTime.TryParseExact(requestEndTime, timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dtEndTime) ||
                    !DateTime.TryParseExact(requestDate, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDateNew))
                {
                    MessageBox.Show(GlobalData.msbErrorDateRQ, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Kiểm tra khoảng thời gian giữa giờ bắt đầu và giờ kết thúc
                TimeSpan difference = dtEndTime - dtStartTime;
                if (difference < TimeSpan.FromHours(1))
                {
                    MessageBox.Show(GlobalData.msbErrorTimeRQ, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Kiểm tra ngày yêu cầu có hợp lệ
                DateTime currentDate = DateTime.Now.Date;
                if ((parsedDateNew < currentDate.AddDays(1) || parsedDateNew > currentDate.AddDays(3)))
                {
                    MessageBox.Show(GlobalData.msbErrorDateRQ, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (checkInsert == 1)
                {
                    // Kiểm tra phòng đã được yêu cầu hay chưa
                    DataTable dataTable = findRequestRoom(roomId, "", "", "", "", 0, "");
                    if (dataTable.Rows.Count > 0)
                    {
                        //dt.Rows[i][0].ToString()
                        //var row = dataTable.Rows[0];

                        string StrRoomID = dataTable.Rows[0][0].ToString();
                        string StrDateOld = dataTable.Rows[0][3].ToString();
                        string StrtimeInStartOld = dataTable.Rows[0][4].ToString();
                        string StrtimeInEndOld = dataTable.Rows[0][5].ToString();



                        // Chuyển đổi dữ liệu cũ
                        DateTime parsedDateOld = DateTime.ParseExact(StrDateOld, "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                        TimeSpan timeInStartOld = TimeSpan.Parse(StrtimeInStartOld);
                        TimeSpan timeInEndOld = TimeSpan.Parse(StrtimeInEndOld);

                        TimeSpan timeInStartNew = dtStartTime.TimeOfDay;
                        TimeSpan timeInEndNew = dtEndTime.TimeOfDay;

                        // So sánh các điều kiện
                        if (parsedDateNew == parsedDateOld &&
                            timeInEndNew >= timeInStartOld &&
                            timeInStartNew <= timeInEndOld)
                        {
                            MessageBox.Show(GlobalData.msbErrorRoomRQTime, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }

                    // Kiểm tra điều kiện bổ sung (tùy thuộc vào checkInsert)
                    if (lr.inforRoom(roomId, 2, "").Rows.Count > 0)
                    {
                        MessageBox.Show(GlobalData.msbErrorRoomRQ, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

                // Nếu tất cả điều kiện đều đúng
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void insertUsageRoom(string index_userId)
        {
            //string deleteSql = "DELETE FROM USAGE_LIST";
            //db.ExecuteNonQuery(deleteSql);
            
            string sql = string.Format("INSERT INTO USAGE_LIST (userId, requestId, usageOccupied) " +
                    "SELECT '{0}', RQR.requestId, 'false' " +
                    "FROM REQUEST_ROOM RQR " +
                    "WHERE RQR.requestStatus = 1 " +
                    "AND NOT EXISTS (SELECT 1 " +
                    "FROM USAGE_LIST UL " +
                    "WHERE UL.requestId = RQR.requestId)", index_userId);
            db.ExecuteNonQuery(sql);
        }

        public void updateStatusRoom(string index_requestId, byte index_bool)
        {
            string str = string.Format("UPDATE USAGE_LIST " +
                "SET usageOccupied = {1} " +
                "WHERE " +
                "requestId = '{0}'", index_requestId, index_bool);
            db.ExecuteNonQuery(str);
        }

        public void updateInforBookingRoom(string index_requestDate, string index_requestReason, string index_adminNote,
                string index_userId, string index_roomId, string index_requestStartTime, string index_requestEndTime, string index_requestId)
        {
            if (checkEmpty(0, index_requestDate, index_requestReason,
            index_userId, index_roomId, index_requestStartTime, index_requestEndTime))
            {
                if (DateTime.TryParseExact(index_requestDate, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDateNew))
                {
                    string StrDateNew = parsedDateNew.ToString(dateFormatSQL);
                    string str = string.Format("UPDATE REQUEST_ROOM " +
                    "SET " +
                    "requestDate = '{0}'," +
                    "requestReason = N'{1}', " +
                    "requestStatus = '1', " +
                    "adminNote = N'{2}', " +
                    "userId = '{3}', " +
                    "roomId = '{4}', " +
                    "requestStartTime = '{5}', " +
                    "requestEndTime = '{6}' " +
                    "WHERE " +
                    "requestId = '{7}'", StrDateNew, index_requestReason, index_adminNote,
                    index_userId, index_roomId, index_requestStartTime, index_requestEndTime, index_requestId);
                    
                    db.ExecuteNonQuery(str);            
                }
            }
        }
        
        public void removeFormRequest(string index_requestId)
        {
            string sql = string.Format("DELETE " +
                "FROM " +
                "REQUEST_ROOM " +
                "WHERE " +
                "requestId = {0}", index_requestId);

            db.ExecuteNonQuery(sql);
        }
    }
}
