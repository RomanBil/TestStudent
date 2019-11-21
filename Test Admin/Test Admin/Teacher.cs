﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
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

        UdpClient clientReceive = new UdpClient(new IPEndPoint(Dns.Resolve(SystemInformation.ComputerName).AddressList[0], 47001));

        List<StudentIp> students = new List<StudentIp>();
        
        public Teacher()
        {
            InitializeComponent();

            Text += "your IP address "+ Dns.Resolve(SystemInformation.ComputerName).AddressList[0].ToString();

            //IPHostEntry iPHostEntry= Dns.GetHostEntry(Dns.GetHostName());

            //MessageBox.Show(iPHostEntry.AddressList[1].ToString());

            Thread receiveThread = new Thread(MyThread);

            receiveThread.IsBackground = true;

            receiveThread.Start(clientReceive);

            //FileStream file = File.Open(@"C: \Users\s30 - r1\Source\Repos\TestStudent2\Test Admin\Test Admin\Tests\", FileMode.Open);

            //for (int i = 0; i < file.; i++)
            //{
                //listView6
            //}
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

                catch (ArgumentException)
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
                    AnswerResult answerResult1 = new AnswerResult() { TextAnswer = "3", Corect = false, StudentCheck = true };

                    AnswerResult answerResult2 = new AnswerResult() { TextAnswer = "4", Corect = true, StudentCheck = false };

                    QuestionResult question = new QuestionResult() { TextQuestion = "2+2",Answers=new List<AnswerResult>() };

                    question.Answers.Add(answerResult1);

                    question.Answers.Add(answerResult2);

                    TestResult test = new TestResult()
                    {
                        Name = "asdasfasdf",
                        NameStudent = string.Empty,
                        Author = "I",
                        CreateDate = DateTime.Now,
                        Subject = "test",
                        Questions = new List<QuestionResult>()
                    };

                    test.Questions.Add(question);

                    //TestResult test = TestResult.ToTestResult(Test t);

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
