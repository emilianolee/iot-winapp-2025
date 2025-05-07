using AxWMPLib;

namespace WinControlsAppDoMyself
{
    public partial class FrmMain : Form
    {
        private bool isPlaying = false;     // ���� ��� ����
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
                Multiselect = true,     // ���� �� ���� ���
                Filter = "Audio Files (*.mp3;*.wav)|*.mp3;*.wav|MP3 Files (*.mp3)|*.mp3|WAV Files (*.wav)|*.wav|All Files (*.*)|*.*"
            };

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // ���ο� ���ϵ��� �߰��� ����
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
                        DialogResult result = MessageBox.Show("�ߺ��� ���� �����ϼ̽��ϴ�. �׷��� �߰��Ͻðڽ��ϱ�?", "�˸�",
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
                MessageBox.Show("�߰��� ���� �����ϼ���!", "����",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (paths != null && ListBoxSongs.SelectedIndex >= 0 && ListBoxSongs.SelectedIndex < paths.Count)
                {
                    // ���� ��� ���� �� ����
                    WindowsMediaApp.Ctlcontrols.stop();

                    // �ణ�� ������ �־� ������ �����ϵ��� ��
                    System.Threading.Thread.Sleep(100);     // 100ms ��ٸ�

                    // ���� URL ����
                    WindowsMediaApp.URL = paths[ListBoxSongs.SelectedIndex];

                    // �ݵ�� ��ġ�� ó������ �ʱ�ȭ
                    WindowsMediaApp.Ctlcontrols.currentPosition = 0;

                    // ���õ� �� ���
                    WindowsMediaApp.Ctlcontrols.play();

                    // ��� ���·� ǥ��
                    isPlaying = true;
                    PbxPlayPause.Image = pauseImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�뷡�� ����ϴ� �� ������ �߻��߽��ϴ� : {ex.Message}", "����",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClearSongs_Click(object sender, EventArgs e)
        {
            int selectedIndex = ListBoxSongs.SelectedIndex;

            if (selectedIndex >= 0)
            {
                bool isCurrentSong = (WindowsMediaApp.URL == paths[selectedIndex]);
                // ����Ʈ���� ����
                ListBoxSongs.Items.RemoveAt(selectedIndex);

                // files�� paths������ ����
                var tempFiles = files.ToList();
                var tempPaths = paths.ToList();
                tempFiles.RemoveAt(selectedIndex);
                tempPaths.RemoveAt(selectedIndex);
                files = tempFiles;
                paths = tempPaths;

                if (isCurrentSong)
                {
                    // ��� ���� �ʱ�ȭ
                    WindowsMediaApp.Ctlcontrols.stop();
                    WindowsMediaApp.URL = "";   // URL���� �ʱ�ȭ����

                    isPlaying = false;
                    PbxPlayPause.Image = playImage;
                    LblCurrTime.Text = "���� ��� �ð�";
                    LblTotalTime.Text = "��ü ��� �ð�";
                    TrbProgress.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("������ ���� �����ϼ���", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClearAllSongs_Click(object sender, EventArgs e)
        {
            if (ListBoxSongs.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("��� ����  �����Ͻðڽ��ϱ�?", "Ȯ��",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ListBoxSongs.Items.Clear();
                    files.Clear();
                    paths.Clear();

                    // ��� ���� �ʱ�ȭ
                    WindowsMediaApp.Ctlcontrols.stop();
                    WindowsMediaApp.URL = "";   // URL���� �ʱ�ȭ����

                    isPlaying = false;
                    PbxPlayPause.Image = playImage;
                    LblCurrTime.Text = "���� ��� �ð�";
                    LblTotalTime.Text = "��ü ��� �ð�";
                    TrbProgress.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("������ ���� �����ϴ�", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(WindowsMediaApp.URL) || WindowsMediaApp.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                LblCurrTime.Text = "���� ��� �ð�";
                LblTotalTime.Text = "��ü ��� �ð�";
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
                    double total = WindowsMediaApp.currentMedia.duration;       // �� ��ü ����
                    double newPosition = (TrbProgress.Value / 100.0) * total;

                    WindowsMediaApp.Ctlcontrols.currentPosition = newPosition;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ʈ���� �̵� ���� : {ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PbxPlayPause_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(WindowsMediaApp.URL))
                {
                    MessageBox.Show("���� ���� �����ϼ���!", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (isPlaying)
                {
                    // ���� ��� �� -> �Ͻ�����
                    WindowsMediaApp.Ctlcontrols.pause();
                    isPlaying = false;
                    PbxPlayPause.Image = playImage;
                }

                else
                {
                    // ���� �Ͻ����� -> ��� ��
                    WindowsMediaApp.Ctlcontrols.play();
                    isPlaying = true;
                    PbxPlayPause.Image = pauseImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"���/�Ͻ����� ���� : {ex.Message}");
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
                MessageBox.Show($"���� ���� : {ex.Message}");
            }
        }
    }
}
