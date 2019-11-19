using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestStudent;

namespace TestNamespace
{
    [Serializable]
    public class StudentIp
    {
        public string LoginStudent { get; set; }

        public IPAddress iPAddressStudent { get; set; }
    }

    [Serializable]
    public class TestResult
    {
        public static TestResult ToTestResult(Test t)
        {
            TestResult tr = new TestResult();

            tr.Author = t.Author;

            tr.NameStudent = null;

            tr.CreateDate = t.CreateDate;

            tr.Name = t.Name;

            tr.Subject = t.Subject;

            for (int i = 0; i < t.Questions.Count(); i++)
            {
                tr.Questions.Add(QuestionResult.ToQuestionResult(t.Questions[i]));
            }

            return tr;
        }

        public string Author { get; set; }

        public string NameStudent { get; set; }
        
        public DateTime CreateDate { get; set; }

        public string Name { get; set; }

        public string Subject { get; set; }

        public List<QuestionResult> Questions { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable]
    public class QuestionResult
    {
        public static QuestionResult ToQuestionResult(Question q)
        {
            QuestionResult qr = new QuestionResult();

            qr.TextQuestion = q.TextQuestion;

            for (int i = 0; i < q.Answers.Count(); i++)
            {
                qr.Answers.Add(AnswerResult.ToAnswerResult(q.Answers[i]));
            }

            return qr;
        }

        public string TextQuestion { get; set; }

        public List<AnswerResult> Answers { get; set; }

        public override string ToString()
        {
            return TextQuestion;
        }
    }

    [Serializable]
    public class AnswerResult
    {
        public static AnswerResult ToAnswerResult(Answer a)
        {
            AnswerResult ar = new AnswerResult();

            ar.TextAnswer = a.TextAnswer;

            ar.Corect = a.Corect;

            ar.StudentCheck = null;

            return ar;
        }

        public string TextAnswer { get; set; }

        public bool Corect { get; set; }

        public bool? StudentCheck { get; set; }
    }
}
