using AxWMPLib;

namespace WinControlsAppDoMyself
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            WindowsMediaApp.Size = new Size(1, 1);

            timer1.Interval = 1000;
            timer1.Start();
        }

        List<string> paths = new List<string>();
        List<string> files = new List<string>();

        private void BtnSelectSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true,     // 여러 곡 선택 허용
                Filter = "Audio Files (*.mp3;*.wav)|*.mp3;*.wav|MP3 Files (*.mp3)|*.mp3|WAV Files (*.wav)|*.wav|All Files (*.*)|*.*"
            };

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // 새로운 파일들을 추가로 누적
                for (int i = 0; i < ofd.FileNames.Length; i++)
                {
                    string fileName = ofd.SafeFileNames[i];
                    string filePath = ofd.FileNames[i];

                    if (!files.Contains(fileName))
                    {
                        files.Add(fileName);
                        paths.Add(filePath);
                        ListBoxSongs.Items.Add(fileName);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("중복된 곡을 선택하셨습니다. 그래도 추가하시겠습니까?", "알림",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            files.Add(fileName);
                            paths.Add(filePath);
                            ListBoxSongs.Items.Add(fileName);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("추가할 곡을 선택하세요!", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void PicX_Click(object sender, EventArgs e)
        {
            // 앱 종료
            this.Close();
        }

        private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (paths != null && ListBoxSongs.SelectedIndex >= 0 && ListBoxSongs.SelectedIndex < paths.Count)
                {
                    // 현재 재생 중인 곡 정지
                    WindowsMediaApp.Ctlcontrols.stop();

                    // 약간의 지연을 주어 완전히 정지하도록 함
                    System.Threading.Thread.Sleep(100);     // 100ms 기다림

                    // 곡의 URL 설정
                    WindowsMediaApp.URL = paths[ListBoxSongs.SelectedIndex];

                    // 반드시 위치를 처음으로 초기화
                    WindowsMediaApp.Ctlcontrols.currentPosition = 0;

                    // 선택된 곡 재생
                    WindowsMediaApp.Ctlcontrols.play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"노래를 재생하는 중 오류가 발생했습니다 : {ex.Message}", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClearSongs_Click(object sender, EventArgs e)
        {
            int selectedIndex = ListBoxSongs.SelectedIndex;

            if (selectedIndex >= 0)
            {
                // 리스트에서 삭제
                ListBoxSongs.Items.RemoveAt(selectedIndex);

                // files와 paths에서도 삭제
                var tempFiles = files.ToList();
                var tempPaths = paths.ToList();
                tempFiles.RemoveAt(selectedIndex);
                tempPaths.RemoveAt(selectedIndex);
                files = tempFiles;
                paths = tempPaths;
            }
            else
            {
                MessageBox.Show("삭제할 곡을 선택하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClearAllSongs_Click(object sender, EventArgs e)
        {
            if (ListBoxSongs.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("모든 곡을  삭제하시겠습니까?", "확인",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ListBoxSongs.Items.Clear();
                    files.Clear();
                    paths.Clear();

                    WindowsMediaApp.Ctlcontrols.stop();
                }
            }
            else
            {
                MessageBox.Show("삭제할 곡이 없습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (WindowsMediaApp.currentMedia != null)
            {
                LblCurrTime.Text = WindowsMediaApp.Ctlcontrols.currentPositionString;
                LblTotalTime.Text = WindowsMediaApp.currentMedia.durationString;

                double current = WindowsMediaApp.Ctlcontrols.currentPosition;
                double total = WindowsMediaApp.currentMedia.duration;

                if (total > 0)
                {
                    int percentage = (int)((current / total) * 100);
                    TrbProgress.Value = Math.Min(percentage, 100);
                }
            }
        }
    }
}
