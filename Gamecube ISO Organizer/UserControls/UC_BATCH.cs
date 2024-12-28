using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamecube_ISO_Organizer.UserControls
{
    public partial class UC_BATCH : UserControl
    {
        public UC_BATCH()
        {
            InitializeComponent();
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
        }
        private void ChooseDirectoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DIRTextBox.Text = dialog.SelectedPath;
            }
        }

        private void OrganizeTask(IProgress<int> progress)
        {
            if (DIRTextBox.Text == "")
            {
                MessageBox.Show("You have no selected directory.");
                return;
            }

            var info = new DirectoryInfo(DIRTextBox.Text);
            var files = info.GetFiles("*.ISO*");

            for (int i = 0; i < files.Length; i++)
            {
                var file = files[i];
                var fileText = File.ReadAllBytes(file.FullName);
                var gameID = fileText.GetID();
                var gameDir = new string(info.FullName + "/" + gameID);
                var gameFolder = Directory.CreateDirectory(gameDir);
                if (File.Exists(gameDir + "/game.iso"))
                {
                    DialogResult result = MessageBox.Show(gameDir + "/game.iso already exists.\nDo you want to overwrite the file?", "Error", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        File.Delete(gameDir + "/game.iso");
                        File.Move(file.FullName, gameDir + "/game.iso");
                    }
                    else
                    {
                        //Do nothing
                    }
                }
                else
                {
                    File.Move(file.FullName, gameDir + "/game.iso");
                }

                var lengthF = (float)files.Length;
                var value = (int)Math.Round(i / lengthF * 100f);
                progress.Report(value);
            }
        }
    }
}
