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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            ListBoxSongs = new ListBox();
            BtnSelectSongs = new Button();
            WindowsMediaApp = new AxWMPLib.AxWindowsMediaPlayer();
            LblDeveloper = new Label();
            BtnClearSongs = new Button();
            BtnClearAllSongs = new Button();
            LblCurrTime = new Label();
            LblTotalTime = new Label();
            TrbProgress = new TrackBar();
            timer1 = new System.Windows.Forms.Timer(components);
            PbxStop = new PictureBox();
            PbxPlayPause = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)WindowsMediaApp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrbProgress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbxStop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbxPlayPause).BeginInit();
            SuspendLayout();
            // 
            // ListBoxSongs
            // 
            ListBoxSongs.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            ListBoxSongs.FormattingEnabled = true;
            ListBoxSongs.ItemHeight = 17;
            ListBoxSongs.Location = new Point(12, 12);
            ListBoxSongs.Name = "ListBoxSongs";
            ListBoxSongs.Size = new Size(242, 106);
            ListBoxSongs.TabIndex = 1;
            ListBoxSongs.SelectedIndexChanged += ListBoxSongs_SelectedIndexChanged;
            // 
            // BtnSelectSongs
            // 
            BtnSelectSongs.BackColor = Color.Red;
            BtnSelectSongs.FlatStyle = FlatStyle.Flat;
            BtnSelectSongs.Font = new Font("Maiandra GD", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSelectSongs.ForeColor = Color.White;
            BtnSelectSongs.Location = new Point(260, 12);
            BtnSelectSongs.Name = "BtnSelectSongs";
            BtnSelectSongs.Size = new Size(120, 30);
            BtnSelectSongs.TabIndex = 2;
            BtnSelectSongs.Text = "Select";
            BtnSelectSongs.UseVisualStyleBackColor = false;
            BtnSelectSongs.Click += BtnSelectSongs_Click;
            // 
            // WindowsMediaApp
            // 
            WindowsMediaApp.Enabled = true;
            WindowsMediaApp.Location = new Point(1000, 1000);
            WindowsMediaApp.Name = "WindowsMediaApp";
            WindowsMediaApp.OcxState = (AxHost.State)resources.GetObject("WindowsMediaApp.OcxState");
            WindowsMediaApp.Size = new Size(442, 309);
            WindowsMediaApp.TabIndex = 3;
            WindowsMediaApp.Visible = false;
            // 
            // LblDeveloper
            // 
            LblDeveloper.AutoSize = true;
            LblDeveloper.ForeColor = SystemColors.ControlDarkDark;
            LblDeveloper.Location = new Point(3, 202);
            LblDeveloper.Name = "LblDeveloper";
            LblDeveloper.Size = new Size(138, 15);
            LblDeveloper.TabIndex = 4;
            LblDeveloper.Text = "Developed By : Emiliano";
            // 
            // BtnClearSongs
            // 
            BtnClearSongs.BackColor = Color.Blue;
            BtnClearSongs.FlatStyle = FlatStyle.Flat;
            BtnClearSongs.Font = new Font("Maiandra GD", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClearSongs.ForeColor = Color.White;
            BtnClearSongs.Location = new Point(260, 48);
            BtnClearSongs.Name = "BtnClearSongs";
            BtnClearSongs.Size = new Size(120, 30);
            BtnClearSongs.TabIndex = 2;
            BtnClearSongs.Text = "Clear";
            BtnClearSongs.UseVisualStyleBackColor = false;
            BtnClearSongs.Click += BtnClearSongs_Click;
            // 
            // BtnClearAllSongs
            // 
            BtnClearAllSongs.BackColor = Color.Indigo;
            BtnClearAllSongs.FlatStyle = FlatStyle.Flat;
            BtnClearAllSongs.Font = new Font("Maiandra GD", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClearAllSongs.ForeColor = Color.White;
            BtnClearAllSongs.Location = new Point(260, 84);
            BtnClearAllSongs.Name = "BtnClearAllSongs";
            BtnClearAllSongs.Size = new Size(120, 30);
            BtnClearAllSongs.TabIndex = 2;
            BtnClearAllSongs.Text = "Clear All";
            BtnClearAllSongs.UseVisualStyleBackColor = false;
            BtnClearAllSongs.Click += BtnClearAllSongs_Click;
            // 
            // LblCurrTime
            // 
            LblCurrTime.Location = new Point(12, 128);
            LblCurrTime.Name = "LblCurrTime";
            LblCurrTime.Size = new Size(87, 15);
            LblCurrTime.TabIndex = 6;
            LblCurrTime.Text = "현재 재생 시간";
            LblCurrTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LblTotalTime
            // 
            LblTotalTime.AutoSize = true;
            LblTotalTime.Location = new Point(293, 128);
            LblTotalTime.Name = "LblTotalTime";
            LblTotalTime.Size = new Size(87, 15);
            LblTotalTime.TabIndex = 7;
            LblTotalTime.Text = "전체 재생 시간";
            // 
            // TrbProgress
            // 
            TrbProgress.Cursor = Cursors.Hand;
            TrbProgress.Location = new Point(98, 128);
            TrbProgress.Maximum = 100;
            TrbProgress.Name = "TrbProgress";
            TrbProgress.Size = new Size(189, 45);
            TrbProgress.TabIndex = 8;
            TrbProgress.TickFrequency = 0;
            TrbProgress.TickStyle = TickStyle.None;
            TrbProgress.ValueChanged += TrbProgress_ValueChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // PbxStop
            // 
            PbxStop.Image = Properties.Resources.stop;
            PbxStop.Location = new Point(203, 152);
            PbxStop.Name = "PbxStop";
            PbxStop.Size = new Size(60, 40);
            PbxStop.SizeMode = PictureBoxSizeMode.Zoom;
            PbxStop.TabIndex = 11;
            PbxStop.TabStop = false;
            PbxStop.Click += PbxStop_Click;
            // 
            // PbxPlayPause
            // 
            PbxPlayPause.Image = Properties.Resources.play;
            PbxPlayPause.Location = new Point(137, 152);
            PbxPlayPause.Name = "PbxPlayPause";
            PbxPlayPause.Size = new Size(60, 40);
            PbxPlayPause.SizeMode = PictureBoxSizeMode.Zoom;
            PbxPlayPause.TabIndex = 12;
            PbxPlayPause.TabStop = false;
            PbxPlayPause.Click += PbxPlayPause_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(392, 225);
            Controls.Add(PbxPlayPause);
            Controls.Add(PbxStop);
            Controls.Add(LblDeveloper);
            Controls.Add(TrbProgress);
            Controls.Add(LblTotalTime);
            Controls.Add(LblCurrTime);
            Controls.Add(WindowsMediaApp);
            Controls.Add(BtnClearSongs);
            Controls.Add(BtnClearAllSongs);
            Controls.Add(BtnSelectSongs);
            Controls.Add(ListBoxSongs);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "음악 재생 앱";
            ((System.ComponentModel.ISupportInitialize)WindowsMediaApp).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrbProgress).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbxStop).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbxPlayPause).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox ListBoxSongs;
        private Button BtnSelectSongs;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaApp;
        private Label LblDeveloper;
        private Button BtnClearSongs;
        private Button BtnClearAllSongs;
        private Label LblCurrTime;
        private Label LblTotalTime;
        private TrackBar TrbProgress;
        private System.Windows.Forms.Timer timer1;
        private PictureBox PbxStop;
        private PictureBox PbxPlayPause;
    }
}
