using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Designer
{
    class Question
    {
        public string TextQuestion { get; set; }
        
        public List<Answer> Answers { get; set; }

        public override string ToString()
        {
            return TextQuestion;
        }
    }
}
