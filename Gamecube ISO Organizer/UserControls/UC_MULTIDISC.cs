using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Gamecube_ISO_Organizer.UserControls
{
    public partial class UC_MULTIDISC : UserControl
    {
        List<string> selectedItems = new List<string>();

        public UC_MULTIDISC()
        {
            InitializeComponent();
        }

        private void ChooseDirectoryButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedItems = new List<string>();
                TextboxDirectory.Text = "";
                for (int i = 0; i < dialog.FileNames.Length; i++)
                {
                    selectedItems.Add(dialog.FileNames[i]);
                    TextboxDirectory.Text += dialog.FileNames[i] + Environment.NewLine;
                }
            }
        }

        private async void RunProgramButton_Click(object sender, EventArgs e)
        {
            var progress = new Progress<int>(percent => { TaskProgressBar.Value = percent; });

            RunProgramButton.Enabled = false; //Disable buttons so we don't mess with the program while running
            ChooseDirectoryButton.Enabled = false; //See Above

            await Task.Run(() => OrganizeTask(progress));

            DialogResult result = MessageBox.Show("Done!", "Task Progress", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
            }

            TaskProgressBar.Value = 0;

            RunProgramButton.Enabled = true; //Disable buttons so we don't mess with the program while running
            ChooseDirectoryButton.Enabled = true; //See Above
            selectedItems = new List<string>();
            TextboxDirectory.Text = "";
        }
        private void OrganizeTask(IProgress<int> progress)
        {
            if (selectedItems == null)
            {
                MessageBox.Show("You have no selected items.");
                return;
            }

            for (int i = 0; i < selectedItems.Count; i++)
            {
                var file = selectedItems[i];
                var fileText = File.ReadAllBytes(file);

                var gameID = fileText.GetID(); //Get The folder name and ID

                var gameDir = new string(Directory.GetParent(file) + "/" + gameID); //Game Folder name and location

                var fileName = ""; //Set intiial name to null value

                if (i > 0)
                {
                    fileName = gameDir + "/disc" + (i + 1).ToString() + ".iso"; //Change to a multidisc
                }
                else
                {
                    fileName = gameDir + "/game.iso"; //Change to main disc
                    var gameFolder = Directory.CreateDirectory(gameDir);
                }

                if (File.Exists(fileName))
                {
                    DialogResult result = MessageBox.Show(fileName + " already exists.\nDo you want to overwrite the file?", "Error", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        File.Delete(fileName);
                        File.Move(file, fileName);
                    }
                    else
                    {
                        //Do nothing
                    }
                }
                else
                {
                    File.Move(file, fileName);
                }
            }
        }
    }
}
