using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStudent
{
    [Serializable]
    public class Test
    {
        public string Author { get; set; }

        public DateTime CreateDate { get; set; }

        public string Name { get; set; }

        public string Subject { get; set; }

        public List<Question> Questions { get; set; }
    }

    [Serializable]
    public class Question
    {
        public string TextQuestion { get; set; }

        public List<Answer> Answers { get; set; }

        public override string ToString()
        {
            return TextQuestion;
        }
    }
    [Serializable]
    public class Answer
    {
        public string TextAnswer { get; set; }

        public bool Corect { get; set; }
    }
}
