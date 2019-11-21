using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using TestStudent;
using TestNamespace;

namespace Test_Client
{
    public partial class ListTest : Form
    {
        UdpClient clientReceive = new UdpClient();

        UdpClient client = new UdpClient(new IPEndPoint(Dns.Resolve(SystemInformation.ComputerName).AddressList[0], 47000));

        private List<TestResult> Tests = new List<TestResult>();

        //IPAddress addressServer = IPAddress.Parse("192.168.28.2");

        IPAddress addressServer = null;

        ///IPHostEntry ipEntry = Dns.GetHostEntry("localhost");

        ////IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
        ////IPAddress iPAddress = ipHost.AddressList[1];




        StudentIp studentIp = new StudentIp()
        {
            LoginStudent = "123",
            iPAddressStudent = Dns.Resolve(SystemInformation.ComputerName).AddressList[0]
        };



        public ListTest(string ip)
        {
            InitializeComponent();

            addressServer = IPAddress.Parse("192.168.28.2");
            ///addressServer = IPAddress.Parse(ip);




            //clientReceive = new UdpClient(new IPEndPoint(addressServer, 47000)); 
            ///MessageBox.Show(Dns.Resolve(SystemInformation.ComputerName).AddressList[0].ToString());

            //IPHostEntry iPHost = Dns.Resolve("localhost");
            //IPAddress iPAddress = iPHost.AddressList[1];

            //IPHostEntry iPHost = Dns.GetHostEntry(Dns.GetHostName());
            ///MessageBox.Show(iPHost.AddressList[1].ToString());
            //IPAddress iPAddress = iPHost.AddressList[1];







            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
            Thread receiveThread = new Thread(MyThread);
            receiveThread.IsBackground = true;
            receiveThread.Start(client);

            IPAddress ipAddr = IPAddress.Parse("192.168.28.2");

            //IPAddress ipAddr = addressServer;

            clientReceive.Connect(ipAddr, 47001);

            MemoryStream memstream = new MemoryStream();

            BinaryFormatter bf = new BinaryFormatter();

            ////bf.Serialize(memstream, test);
            bf.Serialize(memstream, studentIp);

            clientReceive.Send(memstream.ToArray(), (int)memstream.Length);

            memstream.Dispose();
            
          
           
           /* IPAddress ipAddr = IPAddress.Parse("192.168.28.2");
            // Создаем UdpClient
            UdpClient udpClient = new UdpClient();

            // Соединяемся с удаленным хостом
            udpClient.Connect(ipAddr, 47001);

            // Отправка простого сообщения
            byte[] bytes = Encoding.UTF8.GetBytes("Test");
            udpClient.Send(bytes, bytes.Length);
            */


        }

        private void MyThread(Object obj)
        {
            UdpClient client = obj as UdpClient;

            if (client == null)
            {
                throw new ArgumentException("Error");
            }

            while (true)
            {
                IPEndPoint endPoint = null;//new IPEndPoint(addressServer, 47000);

                byte[] data = client.Receive(ref endPoint);

                BinaryFormatter bf = new BinaryFormatter();

                MemoryStream memstream = new MemoryStream(data);

                TestResult testResult = (TestResult)bf.Deserialize(memstream);

                memstream.Dispose();

                listView1.Invoke(new Action(() => { listView1.Items.Add(testResult.ToString()); }));

                Tests.Add(testResult);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Tests.Count(); i++) 
            {
                if (Tests[i].ToString() == listView1.SelectedItems[0].Text)
                {
                    TestForm test = new TestForm(Tests[i], studentIp.LoginStudent);

                    test.ShowDialog();
                }
            }
        }
    }
}
