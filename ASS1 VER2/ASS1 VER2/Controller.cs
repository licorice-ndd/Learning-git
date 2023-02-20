using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1_VER2
{
    internal class Controller : IController
    {
        List<Course> listCourse = new List<Course>();
        List<OnlineCourse> listOnlineCourse = new List<OnlineCourse>(); 
        Validate vali = new Validate();


        public void countDate()
        {
            Console.Write("Start date : ");
            DateTime start = Validate.getDateTime();
            Console.Write("End date : ");
            DateTime end = Validate.getDateTime();
            var betweenDate = new List<Course>();
            foreach (var course in listCourse)
            {
                int first = DateTime.Compare(course.startDate, start);
                int second = DateTime.Compare(course.startDate, end);
                if (first > 0 && second < 0)
                {
                    betweenDate.Add(course);
                }
            }
            displayCourse(betweenDate);
        }

        public void displayCourse(List<Course> listCourse)
        {
            Console.WriteLine();
            listCourse.ForEach(course =>
            {
                Console.WriteLine(course.ToString());
            });
        }
        public bool CheckDuplicateID(int ID)
        {
           foreach(Course course in listCourse)
            {
                if(course.ID == ID)
                {
                    return true;
                }
            }
           return false;
        }

        public bool CheckDuplicateIDOnline(int ID)
        {
            foreach (OnlineCourse onlinecourse in listOnlineCourse)
            {
                if (onlinecourse.ID == ID)
                {
                    return true;
                }
            }
            return false;
        }

        public void DisplayCourse()
        {
            for (int i = 0; i < listCourse.Count; i++)
            {
                Console.WriteLine(listCourse[i].ToString());
            }
        }

        public void DisplayOnlineCourse()
        {
            for (int i = 0; i < listCourse.Count; i++)
            {
                Console.WriteLine(listCourse[i].ToString());
            }
        }

        public   void InputCourse()
        {
            bool flag = true;
            while(flag)
            {
                int ID = vali.GetInt(0, 10, "Enter ID : ");
                string Title = vali.GetString(0, 10, "Enter title : ");
                Console.Write("Enter start date : ");
                DateTime startDate = Validate.getDateTime();
                if (CheckDuplicateID(ID) == false)
                {
                    listCourse.Add(new Course(ID,Title,startDate));
                    flag = false;
                }
                else
                {
                    Console.WriteLine("ID is duplicate please enter again");
                }
            }
        }

        public void InputOnlineCourse()
        {
            bool flag = true;
            while (flag)
            {
                int ID = vali.GetInt(0, 10, "Enter ID : ");
                string Title = vali.GetString(0, 10, "Enter title : ");
                Console.Write("Enter start date : ");
                DateTime startDate = Validate.getDateTime();
                string meet = vali.GetString(0, 10, "Enter meet : ");
                if (CheckDuplicateID(ID) == false)
                {
                    listCourse.Add(new OnlineCourse(ID, Title, startDate,meet));
                    flag = false;
                }
                else
                {
                    Console.WriteLine("ID is duplicate please enter again");
                }
            }
        }

        public void SortCourse()
        {
            var query = from course in listCourse orderby course.Title descending select course;

            foreach (var course in query)
            {
                Console.WriteLine(course);
            }
        }

        public void SortOnlineCourse()
        {
            var query = from course in listCourse orderby course.Title ascending select course;

            foreach (var course in query)
            {
                Console.WriteLine(course);
            }
        }

/*        public override void ReadFromFLine(string line)
        {
            string[] items = line.Split('|');
            Id = Convert.ToInt32()
        }
        public void ReadCourseFromFile(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            string line;
            while(reader.ReadLine() != null)
            {
                line = reader.ReadLine();
                Course course;
                if (line[1] == 'C') course = new Course();
                else course 
            }
        }*/


    }
}
