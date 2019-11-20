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
using TestStudent;

namespace Test_Designer
{
    public partial class Form1 : Form
    {
        private List<Question> Questions = new List<Question>();

        private List<CheckBox> comboBoxes = new List<CheckBox>();

        private List<TextBox> textBoxes = new List<TextBox>();

        private Point point = new Point(0, 30);

        public Form1()
        {
            InitializeComponent();

            panel1.AutoScroll = false;

            panel1.HorizontalScroll.Enabled = false;

            panel1.HorizontalScroll.Visible = false;

            panel1.HorizontalScroll.Maximum = 0;

            panel1.AutoScroll = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Question question = new Question() { TextQuestion = textBoxQuestion.Text, Answers = new List<Answer>() };

            if (comboBoxes.Count > 0)
            {
                for (int i = 0; i < comboBoxes.Count; i++)
                {
                    if (comboBoxes[i].Checked == true)
                    {
                        question.Answers.Add(new Answer() { TextAnswer = textBoxes[i].Text, Corect = true });
                    }

                    else
                    {
                        question.Answers.Add(new Answer() { TextAnswer = textBoxes[i].Text, Corect = false });
                    }
                }
            }

            Questions.Add(question);

            listViewQuestion.Items.Add(question.ToString());

            panel1.Controls.Clear();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            int name = 0;

            panel1.Controls.Clear();

            point = new Point(0, 0);

            for (int i = 0; i < numericUpDown2.Value; i++)
            {
                CheckBox checkBox = new CheckBox();

                checkBox.Location = point;

                checkBox.Name = name.ToString();

                checkBox.Width = 30;

                TextBox textBox = new TextBox();

                point.X = 40;

                textBox.Location = point;

                point.X = 0;

                textBox.Name = name.ToString();

                textBox.Text = "text";

                textBox.Visible = true;

                point.Y += 20;

                panel1.Controls.Add(checkBox);

                panel1.Controls.Add(textBox);

                comboBoxes.Add(checkBox);

                textBoxes.Add(textBox);

                name++;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            FileStream stream = File.OpenWrite(@"C:\Users\s30-r1\Source\Repos\TestStudent2\Test Designer\Test Designer\XMDocument\Tests.xml");

            XmlSerializer ser = new XmlSerializer(typeof(Test));

            Test test = new Test();

            test.Author = textBoxAuthor.Text;

            test.CreateDate = DateTime.Now;

            test.Name = textBoxTheme.Text;

            test.Subject = textBoxSubject.Text;

            test.Questions = Questions;

            ser.Serialize(stream, test);

            stream.Close();
        }
    }
}
