using AxWMPLib;

namespace WinControlsAppDoMyself
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // create globla variables of String Type Array to save the title or name of the Tracks and path of the track
        string[] paths, files;
        private void BtnSelectSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                // Display the music titles in listbox
                for (int i = 0; i < files.Length; i++)
                {
                    ListBoxSongs.Items.Add(files[i]);   // Display songs in ListBox
                }
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
                if (paths != null && ListBoxSongs.SelectedIndex >= 0 && ListBoxSongs.SelectedIndex<paths.Length)
                {
                    // 현재 재생 중인 곡 정지
                    WindowsMediaApp.Ctlcontrols.stop();

                    // 선택된 곡 재생
                    WindowsMediaApp.URL = paths[ListBoxSongs.SelectedIndex];
                    WindowsMediaApp.Ctlcontrols.play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"노래를 재생하는 중 오류가 발생했습니다 : {ex.Message}", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
