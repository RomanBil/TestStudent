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

        UdpClient clientSend = new UdpClient(/*new IPEndPoint(Dns.Resolve(SystemInformation.ComputerName).AddressList[0], 47000)*/);

        UdpClient clientReceive = new UdpClient(/*new IPEndPoint(Dns.Resolve(SystemInformation.ComputerName).AddressList[0], 47001)*/);

        List<StudentIp> students = new List<StudentIp>();
        
        public Teacher()
        {
            InitializeComponent();
            
            //IPHostEntry iPHostEntry= Dns.GetHostEntry(Dns.GetHostName());

            //MessageBox.Show(iPHostEntry.AddressList[1].ToString());

            Thread receiveThread = new Thread(MyThread);

            receiveThread.IsBackground = true;

            receiveThread.Start(clientReceive);

            //Thread readThread = new Thread(ReadResult);

            //readThread.IsBackground = true;

            //readThread.Start(clientReceive);




            //FileStream file = File.Open(@"C: \Users\s30 - r1\Source\Repos\TestStudent2\Test Admin\Test Admin\Tests\", FileMode.Open);

            //for (int i = 0; i < file.; i++)
            //{
                //listView6
            //}
        }

        //private void ReadResult(Object obj)
        //{
        //    UdpClient client = obj as UdpClient;

        //    if (client == null)
        //    {
        //        throw new ArgumentException("Error");
        //    }

        //    while (true)
        //    {
        //        IPEndPoint endPoint = null; //new IPEndPoint(IPAddress.Any, 47002);

        //        byte[] data = client.Receive(ref endPoint);

        //        BinaryFormatter bf = new BinaryFormatter();

        //        MemoryStream memstream = new MemoryStream(data);

        //        TestResult res = (TestResult)bf.Deserialize(memstream);

        //        memstream.Dispose();

        //        for (int i = 0; i < students.Count(); i++)
        //        {
        //            if (students[i].LoginStudent == res.NameStudent) 
        //            {
        //                clientSend.Connect(students[i].iPAddressStudent, 47002);

        //                MemoryStream memstream1 = new MemoryStream();

        //                bf.Serialize(memstream1, res);

        //                clientSend.Send(memstream1.ToArray(), (int)memstream1.Length);

        //                memstream1.Dispose();
        //            }
        //        }
        //    }
        //}

        private void MyThread(Object obj)
        {
            UdpClient client = obj as UdpClient;

            if (client == null)
            {
                throw new ArgumentException("Error");
            }

            while (true)
            {
                IPEndPoint endPoint = null;

                byte[] data = client.Receive(ref endPoint);

                BinaryFormatter bf = new BinaryFormatter();

                MemoryStream memstream = new MemoryStream(data);

                try
                {
                    students.Add((StudentIp)bf.Deserialize(memstream));

                    memstream.Dispose();

                    listView4.Invoke(new Action(() => { listView4.Items.Add(students[students.Count - 1].LoginStudent); }));
                }

                catch (Exception)//no Exception
                {
                    TestResult res = (TestResult)bf.Deserialize(memstream);

                    memstream.Dispose();

                    //обробка res

                    Thread.Sleep(3000);

                    for (int i = 0; i < students.Count(); i++)
                    {
                        if (students[i].LoginStudent == res.NameStudent)
                        {
                            clientSend.Connect(students[i].iPAddressStudent, 47000);

                            MemoryStream memstream1 = new MemoryStream();

                            bf.Serialize(memstream1, res);

                            clientSend.Send(memstream1.ToArray(), (int)memstream1.Length);

                            memstream1.Dispose();
                        }
                    }
                }
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            FileStream read = File.OpenRead(path);

            XmlSerializer ser = new XmlSerializer(typeof(Test));

            Test test = (Test)ser.Deserialize(read);

            read.Close();

            string[] str = path.Split('\\');

            FileStream write = File.Create(@"C:\Users\s30-r1\Source\Repos\TestStudent2\Test Admin\Test Admin\Tests\" + str[str.Length - 1]);
            
            ser.Serialize(write, test);
        }

        private void buttonAddTtoG_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < students.Count(); i++)
            {
                //if (students[i].LoginStudent == "123")
                {
                    TestResult test = TestResult.ToTestResult(new Test() { Name = "asdasfasdf" });

                    clientSend.Connect(students[i].iPAddressStudent, 47000);

                    MemoryStream memstream = new MemoryStream();

                    BinaryFormatter bf = new BinaryFormatter();

                    bf.Serialize(memstream, test);

                    clientSend.Send(memstream.ToArray(), (int)memstream.Length);

                    memstream.Dispose();
                }
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }
        }
    }
}
