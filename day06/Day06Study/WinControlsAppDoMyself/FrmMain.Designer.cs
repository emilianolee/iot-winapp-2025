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
            TopPanel = new Panel();
            PicX = new PictureBox();
            LblLoge = new Label();
            ListBoxSongs = new ListBox();
            BtnSelectSongs = new Button();
            WindowsMediaApp = new AxWMPLib.AxWindowsMediaPlayer();
            LblDeveloper = new Label();
            BtnClearSongs = new Button();
            BtnClearAllSongs = new Button();
            LblTitle = new Label();
            LblCurrTime = new Label();
            LblTotalTime = new Label();
            TrbProgress = new TrackBar();
            timer1 = new System.Windows.Forms.Timer(components);
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WindowsMediaApp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrbProgress).BeginInit();
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
            TopPanel.Size = new Size(527, 38);
            TopPanel.TabIndex = 0;
            // 
            // PicX
            // 
            PicX.Image = (Image)resources.GetObject("PicX.Image");
            PicX.Location = new Point(489, 0);
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
            ListBoxSongs.Location = new Point(12, 44);
            ListBoxSongs.Name = "ListBoxSongs";
            ListBoxSongs.Size = new Size(300, 191);
            ListBoxSongs.TabIndex = 1;
            ListBoxSongs.SelectedIndexChanged += ListBoxSongs_SelectedIndexChanged;
            // 
            // BtnSelectSongs
            // 
            BtnSelectSongs.BackColor = Color.Red;
            BtnSelectSongs.FlatStyle = FlatStyle.Flat;
            BtnSelectSongs.Font = new Font("Maiandra GD", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSelectSongs.ForeColor = Color.White;
            BtnSelectSongs.Location = new Point(332, 44);
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
            LblDeveloper.Location = new Point(377, 315);
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
            BtnClearSongs.Location = new Point(332, 84);
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
            BtnClearAllSongs.Location = new Point(332, 124);
            BtnClearAllSongs.Name = "BtnClearAllSongs";
            BtnClearAllSongs.Size = new Size(120, 30);
            BtnClearAllSongs.TabIndex = 2;
            BtnClearAllSongs.Text = "Clear All";
            BtnClearAllSongs.UseVisualStyleBackColor = false;
            BtnClearAllSongs.Click += BtnClearAllSongs_Click;
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Location = new Point(161, 312);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(47, 15);
            LblTitle.TabIndex = 5;
            LblTitle.Text = "곡 제목";
            // 
            // LblCurrTime
            // 
            LblCurrTime.AutoSize = true;
            LblCurrTime.Location = new Point(12, 264);
            LblCurrTime.Name = "LblCurrTime";
            LblCurrTime.Size = new Size(87, 15);
            LblCurrTime.TabIndex = 6;
            LblCurrTime.Text = "현재 재생 시간";
            // 
            // LblTotalTime
            // 
            LblTotalTime.AutoSize = true;
            LblTotalTime.Location = new Point(428, 264);
            LblTotalTime.Name = "LblTotalTime";
            LblTotalTime.Size = new Size(87, 15);
            LblTotalTime.TabIndex = 7;
            LblTotalTime.Text = "전체 재생 시간";
            // 
            // TrbProgress
            // 
            TrbProgress.Cursor = Cursors.Hand;
            TrbProgress.Location = new Point(98, 264);
            TrbProgress.Maximum = 100;
            TrbProgress.Name = "TrbProgress";
            TrbProgress.Size = new Size(328, 45);
            TrbProgress.TabIndex = 8;
            TrbProgress.TickFrequency = 0;
            TrbProgress.TickStyle = TickStyle.None;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 339);
            Controls.Add(TrbProgress);
            Controls.Add(LblTotalTime);
            Controls.Add(LblCurrTime);
            Controls.Add(LblTitle);
            Controls.Add(LblDeveloper);
            Controls.Add(WindowsMediaApp);
            Controls.Add(BtnClearSongs);
            Controls.Add(BtnClearAllSongs);
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
            ((System.ComponentModel.ISupportInitialize)TrbProgress).EndInit();
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
        private Label LblDeveloper;
        private Button BtnClearSongs;
        private Button BtnClearAllSongs;
        private Label LblTitle;
        private Label LblCurrTime;
        private Label LblTotalTime;
        private TrackBar TrbProgress;
        private System.Windows.Forms.Timer timer1;
    }
}
