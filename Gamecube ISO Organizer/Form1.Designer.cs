namespace Gamecube_ISO_Organizer
{
    partial class GCNProgram
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCNProgram));
            panel1 = new Panel();
            QuitButton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            MultiDiscTabButton = new Button();
            BatchTabButton = new Button();
            PanelContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(QuitButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 54);
            panel1.TabIndex = 6;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // QuitButton
            // 
            QuitButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuitButton.Location = new Point(450, 9);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(47, 39);
            QuitButton.TabIndex = 2;
            QuitButton.Text = "X";
            QuitButton.UseVisualStyleBackColor = true;
            QuitButton.Click += QuitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 30);
            label1.TabIndex = 1;
            label1.Text = "GCN ORGANIZER";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(MultiDiscTabButton);
            panel2.Controls.Add(BatchTabButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 53);
            panel2.TabIndex = 7;
            // 
            // MultiDiscTabButton
            // 
            MultiDiscTabButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MultiDiscTabButton.Location = new Point(129, 6);
            MultiDiscTabButton.Name = "MultiDiscTabButton";
            MultiDiscTabButton.Size = new Size(87, 40);
            MultiDiscTabButton.TabIndex = 1;
            MultiDiscTabButton.Text = "MULTI-DISC";
            MultiDiscTabButton.UseVisualStyleBackColor = true;
            MultiDiscTabButton.Click += MultiDiscTabButton_Click;
            // 
            // BatchTabButton
            // 
            BatchTabButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BatchTabButton.Location = new Point(12, 6);
            BatchTabButton.Name = "BatchTabButton";
            BatchTabButton.Size = new Size(87, 40);
            BatchTabButton.TabIndex = 0;
            BatchTabButton.Text = "BATCH";
            BatchTabButton.UseVisualStyleBackColor = true;
            BatchTabButton.Click += BatchTabButton_Click;
            // 
            // PanelContainer
            // 
            PanelContainer.Dock = DockStyle.Fill;
            PanelContainer.Location = new Point(0, 107);
            PanelContainer.Name = "PanelContainer";
            PanelContainer.Size = new Size(500, 250);
            PanelContainer.TabIndex = 8;
            // 
            // GCNProgram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 357);
            Controls.Add(PanelContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GCNProgram";
            Text = "GCN ORGANIZER";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button MultiDiscTabButton;
        private Button BatchTabButton;
        private Panel PanelContainer;
        private Button QuitButton;
    }
}
