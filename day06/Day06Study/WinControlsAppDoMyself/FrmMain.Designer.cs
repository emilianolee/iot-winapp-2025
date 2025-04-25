namespace WinControlsAppDoMyself
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            TopPanel = new Panel();
            PicX = new PictureBox();
            LblLoge = new Label();
            ListBoxSongs = new ListBox();
            BtnSelectSongs = new Button();
            WindowsMediaApp = new AxWMPLib.AxWindowsMediaPlayer();
            label1 = new Label();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WindowsMediaApp).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.PaleTurquoise;
            TopPanel.Controls.Add(PicX);
            TopPanel.Controls.Add(LblLoge);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(680, 38);
            TopPanel.TabIndex = 0;
            // 
            // PicX
            // 
            PicX.Image = (Image)resources.GetObject("PicX.Image");
            PicX.Location = new Point(644, 0);
            PicX.Name = "PicX";
            PicX.Size = new Size(36, 35);
            PicX.SizeMode = PictureBoxSizeMode.Zoom;
            PicX.TabIndex = 1;
            PicX.TabStop = false;
            PicX.Click += PicX_Click;
            // 
            // LblLoge
            // 
            LblLoge.AutoSize = true;
            LblLoge.Font = new Font("Broadway", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblLoge.Location = new Point(3, 9);
            LblLoge.Name = "LblLoge";
            LblLoge.Size = new Size(128, 15);
            LblLoge.TabIndex = 0;
            LblLoge.Text = "Music Player App";
            // 
            // ListBoxSongs
            // 
            ListBoxSongs.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            ListBoxSongs.FormattingEnabled = true;
            ListBoxSongs.ItemHeight = 17;
            ListBoxSongs.Location = new Point(460, 44);
            ListBoxSongs.Name = "ListBoxSongs";
            ListBoxSongs.Size = new Size(208, 259);
            ListBoxSongs.TabIndex = 1;
            ListBoxSongs.SelectedIndexChanged += ListBoxSongs_SelectedIndexChanged;
            // 
            // BtnSelectSongs
            // 
            BtnSelectSongs.BackColor = Color.OrangeRed;
            BtnSelectSongs.FlatStyle = FlatStyle.Flat;
            BtnSelectSongs.ForeColor = Color.White;
            BtnSelectSongs.Location = new Point(460, 309);
            BtnSelectSongs.Name = "BtnSelectSongs";
            BtnSelectSongs.Size = new Size(208, 44);
            BtnSelectSongs.TabIndex = 2;
            BtnSelectSongs.Text = "Select Songs";
            BtnSelectSongs.UseVisualStyleBackColor = false;
            BtnSelectSongs.Click += BtnSelectSongs_Click;
            // 
            // WindowsMediaApp
            // 
            WindowsMediaApp.Enabled = true;
            WindowsMediaApp.Location = new Point(12, 44);
            WindowsMediaApp.Name = "WindowsMediaApp";
            WindowsMediaApp.OcxState = (AxHost.State)resources.GetObject("WindowsMediaApp.OcxState");
            WindowsMediaApp.Size = new Size(442, 309);
            WindowsMediaApp.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(282, 357);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 4;
            label1.Text = "Developed By : Emiliano";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 380);
            Controls.Add(label1);
            Controls.Add(WindowsMediaApp);
            Controls.Add(BtnSelectSongs);
            Controls.Add(ListBoxSongs);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "음악 재생 앱";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicX).EndInit();
            ((System.ComponentModel.ISupportInitialize)WindowsMediaApp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Label LblLoge;
        private PictureBox PicX;
        private ListBox ListBoxSongs;
        private Button BtnSelectSongs;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaApp;
        private Label label1;
    }
}
