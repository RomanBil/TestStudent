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

namespace Test_Designer
{
    public partial class Form1 : Form
    {
        private List<Question> Questions = new List<Question>();

        ////private List<CheckBox> comboBoxes = new List<CheckBox>();

        private Point point = new Point(0, 0);

      


        public Form1()
        {
            InitializeComponent();

            ////////test();

            checkedListBox1.MultiColumn = false;
            checkedListBox1.SelectionMode = SelectionMode.One;

        }

        private void test()
        {
            ScrollBar vScrollBar1 = new VScrollBar();

            vScrollBar1.Dock = DockStyle.Right;

            vScrollBar1.Scroll += (sender, e) => { panel1.VerticalScroll.Value = vScrollBar1.Value; };
            
            panel1.Controls.Add(vScrollBar1);
        }

        private void buttonAdd_Click(object sender, EventArgs e)  ///add question
        {
            Question question = new Question() { TextQuestion = textBoxQuestion.Text, Answers = new List<Answer>() };

            if (checkedListBox1.Items.Count > 0)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    MessageBox.Show(checkedListBox1.SelectedValue.ToString());



                    //if (checkedListBox1.Items[i] == true)
                    //{
                    //    question.Answers.Add(new Answer() { TextAnswer = comboBoxes[i].Text, Corect = true });
                    //}

                    //else
                    //{
                    //    question.Answers.Add(new Answer() { TextAnswer = comboBoxes[i].Text, Corect = false });
                    //}
                }
            }

            Questions.Add(question);

            listViewQuestion.Items.Add(question.ToString());

            panel1.Controls.Clear();
        }

        private void buttonShow_Click(object sender, EventArgs e)    ///show answer
        {
            if (textBox1.Text == string.Empty)
            {
                return;
            }
            checkedListBox1.Items.Add(textBox1.Text, false);
            textBox1.Text = string.Empty;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            FileStream stream = File.OpenWrite(@"C:\Users\йййй\Source\Repos\TestStudent\Test Designer\Test Designer\XMDocument\Tests.xml");

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
