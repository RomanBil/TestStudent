using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Designer
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
}
