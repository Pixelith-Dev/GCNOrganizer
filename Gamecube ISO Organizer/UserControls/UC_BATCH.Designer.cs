namespace Gamecube_ISO_Organizer.UserControls
{
    partial class UC_BATCH
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BATCH));
            Label_Title = new Label();
            ChooseDirectoryButton = new Button();
            DIRTextBox = new TextBox();
            RunProgramButton = new Button();
            TaskProgressBar = new ProgressBar();
            SuspendLayout();
            // 
            // Label_Title
            // 
            Label_Title.Dock = DockStyle.Top;
            Label_Title.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Title.Location = new Point(0, 0);
            Label_Title.Name = "Label_Title";
            Label_Title.Size = new Size(500, 29);
            Label_Title.TabIndex = 7;
            Label_Title.Text = "BATCH";
            Label_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChooseDirectoryButton
            // 
            ChooseDirectoryButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ChooseDirectoryButton.BackColor = Color.Transparent;
            ChooseDirectoryButton.Image = (Image)resources.GetObject("ChooseDirectoryButton.Image");
            ChooseDirectoryButton.Location = new Point(94, 61);
            ChooseDirectoryButton.Name = "ChooseDirectoryButton";
            ChooseDirectoryButton.Size = new Size(84, 86);
            ChooseDirectoryButton.TabIndex = 8;
            ChooseDirectoryButton.UseVisualStyleBackColor = true;
            ChooseDirectoryButton.Click += ChooseDirectoryButton_Click;
            // 
            // DIRTextBox
            // 
            DIRTextBox.Location = new Point(184, 94);
            DIRTextBox.Name = "DIRTextBox";
            DIRTextBox.ReadOnly = true;
            DIRTextBox.Size = new Size(203, 23);
            DIRTextBox.TabIndex = 9;
            // 
            // RunProgramButton
            // 
            RunProgramButton.Location = new Point(147, 153);
            RunProgramButton.Name = "RunProgramButton";
            RunProgramButton.Size = new Size(207, 29);
            RunProgramButton.TabIndex = 10;
            RunProgramButton.Text = "RUN ORGANIZER";
            RunProgramButton.Click += RunProgramButton_Click;
            // 
            // TaskProgressBar
            // 
            TaskProgressBar.Dock = DockStyle.Bottom;
            TaskProgressBar.Location = new Point(0, 227);
            TaskProgressBar.Name = "TaskProgressBar";
            TaskProgressBar.Size = new Size(500, 23);
            TaskProgressBar.Style = ProgressBarStyle.Continuous;
            TaskProgressBar.TabIndex = 11;
            // 
            // UC_BATCH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TaskProgressBar);
            Controls.Add(RunProgramButton);
            Controls.Add(DIRTextBox);
            Controls.Add(ChooseDirectoryButton);
            Controls.Add(Label_Title);
            Name = "UC_BATCH";
            Size = new Size(500, 250);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Title;
        private Button ChooseDirectoryButton;
        private TextBox DIRTextBox;
        private Button RunProgramButton;
        private ProgressBar TaskProgressBar;
    }
}
