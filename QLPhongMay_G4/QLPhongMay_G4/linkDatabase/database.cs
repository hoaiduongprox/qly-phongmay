using System;
using System.Data;
using System.Data.SqlClient;

namespace QLPhongMay_G4
{
    internal class database
    {
        SqlConnection sqlConn; //Doi tuong ket noi CSDL 
        SqlDataAdapter da;//Bo dieu phoi du lieu 
        DataSet ds; //Doi tuong chhua CSDL khi giao tiep 
        public database()
        {
            string strCnn = "Data Source=PROX-PC\\PROXEXPRESS;Initial Catalog=QLTB;User ID=sa; Password = 123";
            sqlConn = new SqlConnection(strCnn);
        }

        public DataTable Execute(SqlCommand command)
        {
            DataTable dt = new DataTable();
            try
            {
                sqlConn.Open(); // Mở kết nối

                // Gán kết nối cho SqlCommand
                command.Connection = sqlConn;

                // Sử dụng SqlDataAdapter để thực thi command
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt); // Đổ dữ liệu vào DataTable
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thực thi truy vấn: " + ex.Message);
            }
            finally
            {
                sqlConn.Close(); // Đóng kết nối
            }

            return dt;
        }


        //Phuong thuc de thuc hien cac lenh Them, Xoa, Sua 
        public void ExecuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open(); //Mo ket noi 
            sqlcmd.ExecuteNonQuery();//Lenh hien lenh Them/Xoa/Sua 
            sqlConn.Close();//Dong ket noi 
        }
    }
}