using SyntaxWinApp02.Properties;
using System.Net.Security;

namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //Computer myCom = new Computer();

            //Notebook myNoteBook = new Notebook();

            //Server yourServer = new Server();

            //Computer yourCom = new Notebook();  // �θ�Ŭ������ �ڽ� ��ü�� �Ҵ�
            switch (CboDivision.SelectedIndex)
            {
                case 0: // Computer
                    Computer myCom = new Computer();

                    PicComputer.Image = Resources.computer_case;
                    myCom.Boot();
                    myCom.Reset();
                    myCom.Shutdown();
                    break;

                case 1: // Notebook
                    Notebook myBook = new Notebook();
                    PicComputer.Image = Resources.laptop;

                    myBook.Boot();
                    myBook.Shutdown();      // �θ�� �ٸ��� ����

                    // Computer sCom = myBook;
                    // �θ�Ŭ������ �ڽ�Ŭ������ ����ȯ�ϸ鼭 ������ �߻��� ������ ����
                    //Notebook myBook2 = (Notebook)new Computer();
                    Computer myComputer = new Notebook();

                    if (myComputer is Notebook)
                    {
                        Console.WriteLine("myBook is NoteBook");
                        Notebook myBook2 = myComputer as Notebook;
                        Console.WriteLine("myComputer�� NoteBook���� ����~");
                    }

                    // �����ν� Ȯ��
                    bool hasFinger = myBook.HasFingerScanDevice();
                    Console.WriteLine($"���� �����νĿ��� : {hasFinger}");
                    // �޼��� �����ε�
                    hasFinger = myBook.HasFingerScanDevice(true);
                    Console.WriteLine($"���� �����νĿ��� : {hasFinger}");
                    break;

                case 2: // Server
                    Server yourServ = new Server();
                    PicComputer.Image = Resources.server;
                    break;
                default:
                    break;
            }
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Server server1 = new Server();
            server1.Name = "HP����";

            // ���� ���� : ���� ���� ����
            Server server2 = server1;   
            server2.Name = "DELL����";

            bool isSame = server1.Equals(server2);
            Console.WriteLine(isSame);
            
            MessageBox.Show($"{server1.Name}\r\n{server2.Name}", "������");

            // ���� ���� : ���� �ٸ� ��ü�� ����
            Server server3 = server1.DeepCopy();
            server3.Name = "INTEL����";

            isSame = server2.Equals(server3);
            Console.WriteLine(isSame);

            MessageBox.Show($"{server1.Name}\r\n{server3.Name}", "������");
        }
    }
}
