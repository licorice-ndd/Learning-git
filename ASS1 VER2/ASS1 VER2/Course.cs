using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1_VER2
{
    internal class Course
    {

        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime startDate { get; set; }

        public Course() { }

        public Course(int id, string title, DateTime startdate)
        {
            ID = id;   
            Title = title;
            this.startDate = startdate;
        }

        public override string ToString()
        {
            return "ID : " + ID + " Title : " + Title + " Start date : " + startDate.ToString();
        }
    }
}
