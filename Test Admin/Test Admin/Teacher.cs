using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TestNamespace;
using TestStudent;

namespace Test_Admin
{
    public partial class Teacher : Form
    {
        string path;

        UdpClient clientSend = new UdpClient(new IPEndPoint(Dns.Resolve(SystemInformation.ComputerName).AddressList[0], 47000));

        UdpClient clientReceive = new UdpClient(new IPEndPoint(Dns.Resolve(SystemInformation.ComputerName).AddressList[0], 47001));

        List<StudentIp> students = new List<StudentIp>();

        public Teacher()
        {
            InitializeComponent();

            Thread receiveThread = new Thread(MyThread);

            receiveThread.IsBackground = true;

            receiveThread.Start(clientReceive);

            Thread readThread = new Thread(ReadResult);

            readThread.IsBackground = true;

            readThread.Start(clientReceive);
        }

        private void ReadResult(Object obj)
        {
            UdpClient client = obj as UdpClient;

            if (client == null)
            {
                throw new ArgumentException("Error");
            }

            while (true)
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 47002);

                byte[] data = client.Receive(ref endPoint);

                BinaryFormatter bf = new BinaryFormatter();

                MemoryStream memstream = new MemoryStream(data);

                TestResult res = (TestResult)bf.Deserialize(memstream);

                memstream.Dispose();

                for (int i = 0; i < students.Count(); i++)
                {
                    if (students[i].LoginStudent == res.NameStudent) 
                    {
                        clientSend.Connect(students[i].iPAddressStudent, 47002);

                        MemoryStream memstream1 = new MemoryStream();

                        bf.Serialize(memstream1, res);

                        clientSend.Send(memstream1.ToArray(), (int)memstream1.Length);

                        memstream1.Dispose();
                    }
                }
            }
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
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 47000);

                byte[] data = client.Receive(ref endPoint);

                BinaryFormatter bf = new BinaryFormatter();

                MemoryStream memstream = new MemoryStream(data);

                students.Add((StudentIp)bf.Deserialize(memstream));

                memstream.Dispose();
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            FileStream read = File.OpenWrite(path);

            XmlSerializer ser = new XmlSerializer(typeof(Test));

            Test test = (Test)ser.Deserialize(read);

            read.Close();

            FileStream write = File.OpenWrite(@"C:\Users\йййй\Source\Repos\TestStudent\Test Admin\Test Admin\Tests\");

            ser.Serialize(write, test);
        }

        private void buttonAddTtoG_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < students.Count(); i++)
            {
                if (students[i].LoginStudent == "login student from group")
                {
                    TestResult test = TestResult.ToTestResult(new Test());

                    clientSend.Connect(students[i].iPAddressStudent, 47001);

                    MemoryStream memstream = new MemoryStream();

                    BinaryFormatter bf = new BinaryFormatter();

                    bf.Serialize(memstream, test);

                    clientSend.Send(memstream.ToArray(), (int)memstream.Length);

                    memstream.Dispose();
                }
            }
        }
    }
}
