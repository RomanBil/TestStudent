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
using TestNamespace;

namespace Test_Client
{
    public partial class TestResultForm : Form
    {
        UdpClient clientReceive = new UdpClient(new IPEndPoint(Dns.Resolve(SystemInformation.ComputerName).AddressList[0], 47001));

        public TestResultForm()
        {
            InitializeComponent();

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
            }
        }
    }
}
