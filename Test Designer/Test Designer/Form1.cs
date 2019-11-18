using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Designer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();

            for (int i = 0; i < numericUpDown2.Value; i++)
            {
                groupBox1.Controls.Add(new CheckBox());
            }
        }
    }
}
