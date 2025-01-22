using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongMay_G4.modal;

namespace QLPhongMay_G4
{
    public partial class editMiniModal : Form
    {
        public editMiniModal()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();

            if (formOpenMiniModal.modal == "device")
            {
                EMM_DEVICE modal = new EMM_DEVICE();
                addUserControl(modal);
            }
            if (formOpenMiniModal.modal == "room")
            {
                EMM_ROOM modal = new EMM_ROOM();
                addUserControl(modal);
            }
            if (formOpenMiniModal.modal == "account")
            {
                EMM_ACCOUNT modal = new EMM_ACCOUNT();
                addUserControl(modal);
            }
        }
      
        public static class formOpenMiniModal
        {
            public static string modal { get; set; } = "false"; //false = ROOM ; true = DEVICE;
        }

        void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainerModal.Controls.Clear();
            panelContainerModal.Controls.Add(userControl);
            userControl.BringToFront();
        }

    }
}
