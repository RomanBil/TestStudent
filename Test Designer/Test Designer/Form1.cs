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
        private List<Question> Questions = new List<Question>();

        private List<CheckBox> comboBoxes = new List<CheckBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Question question = new Question() { TextQuestion = textBoxQuestion.Text };

            if (comboBoxes.Count > 0)
            {
                for (int i = 0; i < comboBoxes.Count; i++)
                {
                    if (comboBoxes[i].Checked == true)
                    {
                        question.Answers.Add(new Answer() { TextAnswer = comboBoxes[i].Text, Corect = true });
                    }

                    else
                    {
                        question.Answers.Add(new Answer() { TextAnswer = comboBoxes[i].Text, Corect = false });
                    }
                }
            }

            Questions.Add(question);
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();

            for (int i = 0; i < numericUpDown2.Value; i++)
            {
                CheckBox comboBox = new CheckBox();

                groupBox1.Controls.Add(comboBox);

                comboBoxes.Add(comboBox);
            }
        }
    }
}
