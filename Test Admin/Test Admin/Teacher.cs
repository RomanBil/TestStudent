using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TestNamespace;

namespace Test_Admin
{
    public partial class Teacher : Form
    {
        string path;

        public Teacher()
        {
            InitializeComponent();
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
    }
}
