using AxWMPLib;

namespace WinControlsAppDoMyself
{
    public partial class FrmMain : Form
    {
        private bool isPlaying = false;     // 현재 재생 상태
        private Image playImage = Properties.Resources.play;
        private Image pauseImage = Properties.Resources.pause;
        public FrmMain()
        {
            InitializeComponent();


            WindowsMediaApp.Size = new Size(1, 1);

            timer1.Interval = 1000;
            timer1.Start();

            PbxPlayPause.Image = playImage;
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

                    // 재생 상태로 표시
                    isPlaying = true;
                    PbxPlayPause.Image = pauseImage;
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
                bool isCurrentSong = (WindowsMediaApp.URL == paths[selectedIndex]);
                // 리스트에서 삭제
                ListBoxSongs.Items.RemoveAt(selectedIndex);

                // files와 paths에서도 삭제
                var tempFiles = files.ToList();
                var tempPaths = paths.ToList();
                tempFiles.RemoveAt(selectedIndex);
                tempPaths.RemoveAt(selectedIndex);
                files = tempFiles;
                paths = tempPaths;

                if (isCurrentSong)
                {
                    // 재생 정보 초기화
                    WindowsMediaApp.Ctlcontrols.stop();
                    WindowsMediaApp.URL = "";   // URL까지 초기화해줌

                    isPlaying = false;
                    PbxPlayPause.Image = playImage;
                    LblCurrTime.Text = "현재 재생 시간";
                    LblTotalTime.Text = "전체 재생 시간";
                    TrbProgress.Value = 0;
                }
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

                    // 재생 정보 초기화
                    WindowsMediaApp.Ctlcontrols.stop();
                    WindowsMediaApp.URL = "";   // URL까지 초기화해줌

                    isPlaying = false;
                    PbxPlayPause.Image = playImage;
                    LblCurrTime.Text = "현재 재생 시간";
                    LblTotalTime.Text = "전체 재생 시간";
                    TrbProgress.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("삭제할 곡이 없습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(WindowsMediaApp.URL) || WindowsMediaApp.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                LblCurrTime.Text = "현재 재생 시간";
                LblTotalTime.Text = "전체 재생 시간";
                TrbProgress.Value = 0;
            }
            else if (WindowsMediaApp.currentMedia != null) 
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

        private void TrbProgress_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (WindowsMediaApp.currentMedia != null)
                {
                    double total = WindowsMediaApp.currentMedia.duration;       // 곡 전체 길이
                    double newPosition = (TrbProgress.Value / 100.0) * total;

                    WindowsMediaApp.Ctlcontrols.currentPosition = newPosition;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"트랙바 이동 오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PbxPlayPause_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(WindowsMediaApp.URL))
                {
                    MessageBox.Show("먼저 곡을 선택하세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (isPlaying)
                {
                    // 현재 재생 중 -> 일시정지
                    WindowsMediaApp.Ctlcontrols.pause();
                    isPlaying = false;
                    PbxPlayPause.Image = playImage;
                }

                else
                {
                    // 현재 일시정지 -> 재생 중
                    WindowsMediaApp.Ctlcontrols.play();
                    isPlaying = true;
                    PbxPlayPause.Image = pauseImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"재생/일시정지 오류 : {ex.Message}");
            }
        }

        private void PbxStop_Click(object sender, EventArgs e)
        {
            try
            {
                WindowsMediaApp.Ctlcontrols.stop();
                isPlaying = false;
                PbxPlayPause.Image = playImage;

                if (WindowsMediaApp.currentMedia !=  null)
                {
                    LblCurrTime.Text = "00:00";
                    LblTotalTime.Text = WindowsMediaApp.currentMedia.durationString;
                    TrbProgress.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"정지 오류 : {ex.Message}");
            }
        }
    }
}
