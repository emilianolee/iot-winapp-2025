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
            // 기본 생성자
            Person emiliano = new Person();
            emiliano.Name = TxtName.Text.Trim();
            emiliano.Age = int.Parse(TxtAge.Text.Trim());
            emiliano.Gender = char.Parse(TxtGender.Text.Trim());
            emiliano.Phone = TxtPhone.Text.Trim();

            // 매개변수 생성자
            Person LJ = new Person("LJ", 25, 'F', "010-9999-8888");

            TxtResult.Text += emiliano.ToString();
            emiliano.Getup();
            emiliano.GoToSchool();

            // static일 경우는 객체를 생성하지 않음
            Person.GetNumber();
        }
    }
}
