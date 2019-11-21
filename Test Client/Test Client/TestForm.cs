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
using System.Threading.Tasks;
using System.Windows.Forms;
using TestNamespace;
using TestStudent;

namespace Test_Client
{
    public partial class TestForm : Form
    {
        UdpClient clientSend = new UdpClient(/*new IPEndPoint(Dns.Resolve(SystemInformation.ComputerName).AddressList[0], 47000)*/);

        TestResult test = null;

        private Point point = new Point(0, 0);

        private List<CheckBox> checkBoxes = new List<CheckBox>();

        public TestForm(TestResult tr, string NameStudent)
        {
            InitializeComponent();

            test.NameStudent = NameStudent;

            test = tr;

            for (int i = 0; i < test.Questions.Count(); i++)
            {
                listView1.Items.Add(test.Questions[i].ToString());
            }

            listView1.FocusedItem = listView1.Items[0];

            Func();
        }

        private void Func()
        {
            checkBoxes.Clear();

            panel1.Controls.Clear();

            point = new Point(0, 0);

            ////for (int i = 0; i < (listView1.FocusedItem as QuestionResult).Answers.Count; i++)
            ////{
            ////    int name = 0;

            ////    CheckBox checkBox = new CheckBox();

            ////    checkBox.Location = point;

            ////    checkBox.Name = name.ToString();

            ////    checkBox.Text = (listView1.FocusedItem as QuestionResult).Answers[i].TextAnswer;

            ////    point.Y += 20;

            ////    name++;

            ////    panel1.Controls.Add(checkBox);

            ////    checkBoxes.Add(checkBox);
            ////}
        }

        private void SaveAnswers()
        {
            for (int i = 0; i < test.Questions[listView1.FocusedItem.Index].Answers.Count(); i++)
            {
                if (checkBoxes[i].Checked == true)
                {
                    test.Questions[listView1.FocusedItem.Index].Answers[i].StudentCheck = true;
                }

                else
                {
                    test.Questions[listView1.FocusedItem.Index].Answers[i].StudentCheck = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IPAddress addressServer = IPAddress.Parse("192.168.28.2");

            clientSend.Connect(addressServer, 47001);

            MemoryStream memstream = new MemoryStream();

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(memstream, test);

            clientSend.Send(memstream.ToArray(), (int)memstream.Length);

            memstream.Dispose();

            TestResultForm trf = new TestResultForm();

            trf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveAnswers();

            Func();

            listView1.FocusedItem = listView1.Items[listView1.FocusedItem.Index + 1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.FocusedItem = listView1.Items[listView1.FocusedItem.Index - 1];

            Func();

            SaveAnswers();
        }
    }
}
