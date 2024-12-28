using static System.Net.Mime.MediaTypeNames;
using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Gamecube_ISO_Organizer.Properties;
using Gamecube_ISO_Organizer.UserControls;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace Gamecube_ISO_Organizer
{
    public partial class GCNProgram : Form
    {
        public GCNProgram()
        {
            FormBorderStyle = FormBorderStyle.None;

            InitializeComponent();

            UC_BATCH UCMD = new UC_BATCH();
            AddUserControl(UCMD);

        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void BatchTabButton_Click(object sender, EventArgs e)
        {
            UC_BATCH UCMD = new UC_BATCH();
            AddUserControl(UCMD);
        }
        private void MultiDiscTabButton_Click(object sender, EventArgs e)
        {
            UC_MULTIDISC UCMD = new UC_MULTIDISC();
            AddUserControl(UCMD);
        }

        bool movePosition;
        int xCoordinates;
        int yCoordinates;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            movePosition = true;
            xCoordinates = e.X;
            yCoordinates = e.Y;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (movePosition)
            {
                this.SetDesktopLocation(MousePosition.X - xCoordinates, MousePosition.Y - yCoordinates);
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            movePosition = false;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
