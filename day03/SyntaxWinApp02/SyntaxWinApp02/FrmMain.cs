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

            //Computer yourCom = new Notebook();  // 부모클래스에 자식 객체를 할당
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
                    myBook.Shutdown();      // 부모와 다르게 동작

                    // Computer sCom = myBook;
                    // 부모클래스를 자식클래스에 형변환하면서 문제가 발생할 소지가 있음
                    //Notebook myBook2 = (Notebook)new Computer();
                    Computer myComputer = new Notebook();

                    if (myComputer is Notebook)
                    {
                        Console.WriteLine("myBook is NoteBook");
                        Notebook myBook2 = myComputer as Notebook;
                        Console.WriteLine("myComputer를 NoteBook으로 변경~");
                    }

                    // 지문인식 확인
                    bool hasFinger = myBook.HasFingerScanDevice();
                    Console.WriteLine($"최초 지문인식여부 : {hasFinger}");
                    // 메서드 오버로드
                    hasFinger = myBook.HasFingerScanDevice(true);
                    Console.WriteLine($"최종 지문인식여부 : {hasFinger}");
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
            server1.Name = "HP서버";

            // 얕은 복사 : 같은 내용 참조
            Server server2 = server1;   
            server2.Name = "DELL서버";

            bool isSame = server1.Equals(server2);
            Console.WriteLine(isSame);
            
            MessageBox.Show($"{server1.Name}\r\n{server2.Name}", "서버명");

            // 깊은 복사 : 완전 다른 객체로 복사
            Server server3 = server1.DeepCopy();
            server3.Name = "INTEL서버";

            isSame = server2.Equals(server3);
            Console.WriteLine(isSame);

            MessageBox.Show($"{server1.Name}\r\n{server3.Name}", "서버명");
        }
    }
}
