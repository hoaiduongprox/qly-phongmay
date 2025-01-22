using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongMay_G4.controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static QLPhongMay_G4.editRoomRequest;
using static QLPhongMay_G4.loginPortal;

namespace QLPhongMay_G4.UC_TabControl
{
    public partial class ITRM_tab2 : UserControl
    {
        public ITRM_tab2()
        {
            processToForm.verifyFormTab2 = true;
            InitializeComponent();

            EventManager.ButtonClicked += ITRM_tab2_Load; //
        }

        loadRequestRoom lrequestr = new loadRequestRoom();
        commonFormat cf = new commonFormat();

        public void loadFormRequestRoom()
        {
            listView1.Items.Clear();

            string userIdSelected = "";
            if (GlobalData.dataUserRole == "user")
                userIdSelected = GlobalData.dataUserId;
            

            DataTable dt = lrequestr.loadInforRequests("", userIdSelected);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int countItem = i + 1;
                ListViewItem lvi =
                listView1.Items.Add(countItem.ToString());
                lvi.SubItems.Add("Khu I");
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][8].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString() + " chổ");

                //
                if (DateTime.TryParse(dt.Rows[i][5].ToString(), out DateTime date))
                    lvi.SubItems.Add(date.ToString("dd/MM/yyyy"));
                else
                    lvi.SubItems.Add(dt.Rows[i][5].ToString());

                //
                if (DateTime.TryParse(dt.Rows[i][6].ToString(), out DateTime time))
                    lvi.SubItems.Add(time.ToString("HH:mm"));
                else
                    lvi.SubItems.Add(dt.Rows[i][6].ToString());

                //
                if (DateTime.TryParse(dt.Rows[i][7].ToString(), out DateTime time1))
                    lvi.SubItems.Add(time1.ToString("HH:mm"));
                else
                    lvi.SubItems.Add(dt.Rows[i][7].ToString());

                lvi.SubItems.Add(dt.Rows[i][11].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (GlobalData.dataUserRole != "user")
            {
                processToForm.dataButtonF1toF2 = true;
                itRoomManagement formIn = new itRoomManagement();
                string RequestIdSelect = listView1.SelectedItems[0].SubItems[8].Text;
                cf.openEditRequest(RequestIdSelect);

            }
        }

        private void ITRM_tab2_Load(object sender, EventArgs e)
        {
            loadFormRequestRoom();
        }
    }
}
