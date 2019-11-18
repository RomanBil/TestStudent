using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Designer
{
    [Serializable]
    public class Answer
    {
        public string TextAnswer { get; set; }

        public bool Corect { get; set; }
    }
}
