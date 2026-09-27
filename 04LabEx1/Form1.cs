using System.Runtime.InteropServices;
using static _04LabEx1.MyThreadClass;
using System.Threading;
namespace _04LabEx1


{
    public partial class Form1 : Form
    {
        Thread ThreadA;
        Thread ThreadB;
        ThreadStart TA = new ThreadStart(Thread1);
        ThreadStart TB = new ThreadStart(Thread1);
        
        
        public Form1()
        {
            InitializeComponent();
            ThreadA = new Thread(TA);
            ThreadB = new Thread(TB);

            ThreadA.Name = "ThreadA";
            ThreadB.Name = "ThreadB";
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();      

        private void button1_Click(object sender, EventArgs e)
        {
            AllocConsole();
            Console.WriteLine("-Before starting thread-");
            

           
            ThreadA.Start();
            ThreadB.Start();
            ThreadB.Join();
            ThreadA.Join();

            if (!ThreadA.IsAlive&&!ThreadB.IsAlive)
            {
                Console.WriteLine("-End Of Thread-");
                label1.Text = "-End Of Thread-";
            }
        }
    }
}
