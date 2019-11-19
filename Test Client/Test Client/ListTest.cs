using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Client
{
    public partial class ListTest : Form
    {
        public ListTest()
        {
            InitializeComponent();

            panel1.AutoScroll = false;

            panel1.HorizontalScroll.Enabled = false;

            panel1.HorizontalScroll.Visible = false;

            panel1.HorizontalScroll.Maximum = 0;

            panel1.AutoScroll = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test test = new Test();

            test.ShowDialog();
        }
    }
}
