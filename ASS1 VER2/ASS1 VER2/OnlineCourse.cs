using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1_VER2
{
    internal class OnlineCourse : Course
    {
        public string Meet { get; set; }

        public OnlineCourse() { }
        public OnlineCourse(int id, string title, DateTime startDate, string meet) : base(id, title, startDate)
        {
            Meet = meet;
        }

        public override string ToString()
        {
            return base.ToString() + "  Meet : " + Meet;
        }
    }
}
