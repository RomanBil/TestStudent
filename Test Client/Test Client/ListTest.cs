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
//using TestNamespace;
using TestStudent;
using TestNamespace;
using System.Net.Http;

namespace Test_Client
{
    public partial class ListTest : Form
    {
        UdpClient clientReceive = new UdpClient();

        
        //IPAddress addressServer = IPAddress.Parse("ip adres");
        IPAddress addressServer = IPAddress.Parse("192.168.28.2");
        


        ///IPHostEntry ipEntry = Dns.GetHostEntry("localhost");

        ////IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
        ////IPAddress iPAddress = ipHost.AddressList[1];





        public ListTest()
        {
            InitializeComponent();

            //clientReceive = new UdpClient(new IPEndPoint(addressServer, 47000)); 


            ///MessageBox.Show(Dns.Resolve(SystemInformation.ComputerName).AddressList[0].ToString());

            //IPHostEntry iPHost = Dns.Resolve("localhost");
            //IPAddress iPAddress = iPHost.AddressList[1];


            IPHostEntry iPHost = Dns.GetHostEntry(Dns.GetHostName());
            ///MessageBox.Show(iPHost.AddressList[1].ToString());
            IPAddress iPAddress = iPHost.AddressList[1];




            StudentIp studentIp = new StudentIp() { LoginStudent = "123", iPAddressStudent = iPAddress };

          

            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
            //Thread receiveThread = new Thread(MyThread);
            //receiveThread.IsBackground = true;
            //receiveThread.Start(clientReceive);

            IPAddress ipAddr = IPAddress.Parse("192.168.28.2");
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
                IPEndPoint endPoint = new IPEndPoint(addressServer, 47001);

                byte[] data = client.Receive(ref endPoint);

                BinaryFormatter bf = new BinaryFormatter();

                MemoryStream memstream = new MemoryStream(data);

                ///Test test = (Test)bf.Deserialize(memstream);

                TestResult testResult = (TestResult)bf.Deserialize(memstream);

                memstream.Dispose();

                ////listView1.Items.Add(Test.ToString());

                MessageBox.Show(testResult.ToString());

                listView1.Items.Add(testResult.ToString());



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestForm test = new TestForm();

            test.ShowDialog();
        }
    }
}
