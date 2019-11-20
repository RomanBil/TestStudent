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

        public TestForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IPAddress addressServer = IPAddress.Parse("192.168.28.2");

            TestResult test = new TestResult();

            clientSend.Connect(addressServer, 47001);

            MemoryStream memstream = new MemoryStream();

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(memstream, test);

            clientSend.Send(memstream.ToArray(), (int)memstream.Length);

            memstream.Dispose();

            TestResultForm trf = new TestResultForm();

            trf.ShowDialog();
        }
    }
}
