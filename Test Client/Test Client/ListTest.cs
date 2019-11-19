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
using TestNamespace;

namespace Test_Client
{
    public partial class ListTest : Form
    {
        UdpClient clientReceive = new UdpClient(new IPEndPoint(Dns.Resolve(SystemInformation.ComputerName).AddressList[0], 47000));

        IPAddress addressServer = IPAddress.Parse("ip adres");

        public ListTest()
        {
            InitializeComponent();

            panel1.AutoScroll = false;

            panel1.HorizontalScroll.Enabled = false;

            panel1.HorizontalScroll.Visible = false;

            panel1.HorizontalScroll.Maximum = 0;

            panel1.AutoScroll = true;

            Thread receiveThread = new Thread(MyThread);

            receiveThread.IsBackground = true;

            receiveThread.Start(clientReceive);
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

                Test test = (Test)bf.Deserialize(memstream);

                memstream.Dispose();

                listView1.Items.Add(Test.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestForm test = new TestForm();

            test.ShowDialog();
        }
    }
}
