namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        private void BtnMsg_Click(object sender, EventArgs e)
        {
            // ������ : =, +, -, *, /, %, ^, +=, -=, *=
            // &&, ||, &, |, ^, !
            // C, C++ �� ����
            int val = 2 ^ 10;

            int result = 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2;

            MessageBox.Show(result.ToString(), "�˸�", MessageBoxButtons.OK);
            //MessageBox.Show(result.ToString(), "�˸�", MessageBoxButtons.OK);
        }
    }
}
