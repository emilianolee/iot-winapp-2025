namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Btncheck_Click(object sender, EventArgs e)
        {
            // �⺻ ������
            Person emiliano = new Person();
            emiliano.Name = TxtName.Text.Trim();
            emiliano.Age = int.Parse(TxtAge.Text.Trim());
            emiliano.Gender = char.Parse(TxtGender.Text.Trim());
            emiliano.Phone = TxtPhone.Text.Trim();

            // �Ű����� ������
            Person LJ = new Person("LJ", 25, 'F', "010-9999-8888");

            TxtResult.Text += emiliano.ToString();
            emiliano.Getup();
            emiliano.GoToSchool();

            // static�� ���� ��ü�� �������� ����
            Person.GetNumber();
        }
    }
}
