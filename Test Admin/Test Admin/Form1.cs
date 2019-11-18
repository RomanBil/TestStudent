using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();

            if (true)
            {
                Admin admin = new Admin();

                admin.ShowDialog();
            }

            else
            {
                Teacher teacher = new Teacher();

                teacher.ShowDialog();
            }

            Close();
        }
    }
}
