﻿using System;
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

        private List<CheckBox> comboBoxes = new List<CheckBox>();

        private Point point = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
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
                        question.Answers.Add(new Answer() { TextAnswer = comboBoxes[i].Text, Corect = true });
                    }

                    else
                    {
                        question.Answers.Add(new Answer() { TextAnswer = comboBoxes[i].Text, Corect = false });
                    }
                }
            }

            Questions.Add(question);

            listViewQuestion.Items.Add(question.ToString());

            groupBox1.Controls.Clear();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();

            point = new Point(0, 0);

            for (int i = 0; i < numericUpDown2.Value; i++)
            {
                CheckBox checkBox = new CheckBox();

                checkBox.Location = point;

                checkBox.Text = "text";

                point.Y += 20;

                groupBox1.Controls.Add(checkBox);

                comboBoxes.Add(checkBox);
            }
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
