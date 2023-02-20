using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1_VER2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            Validate vali = new Validate();
            Controller control = new Controller();
            Employee employee = new Employee();

            while (true)
            {
                Console.WriteLine("\n --------------------- Menu ---------------------");
                Console.WriteLine("1. Input a course");
                Console.WriteLine("2. Input a online course");
                Console.WriteLine("3. Display list of course/online course");
                Console.WriteLine("4. Find course");
                Console.WriteLine("5. Sort list of course des");
                Console.WriteLine("6. Sort list of course asc");
                Console.WriteLine("7. Exit");
                Console.WriteLine("8. display employee");
                Console.WriteLine("9. search employee by id, name, position");
                Console.WriteLine("10. search employee by salary trong khoang ");
                Console.WriteLine("11. search employee by GetSalary");

                option = vali.GetInt(1, 15, "Enter choice : ");
                switch (option)
                {
                    case 1:
                        {
                            control.InputCourse();
                            break;
                        }
                    case 2:
                        {
                            control.InputOnlineCourse();
                            break;
                        }
                    case 3:
                        {
                            control.DisplayCourse();
                            break;
                        }
                    case 4:
                        {
                            control.countDate();
                            break;
                        }
                    case 5:
                        {
                            control.SortCourse();
                            break;
                        }
                    case 6:
                        {
                            control.SortOnlineCourse();
                            break;
                        }
                    case 7:
                        {                        
                            return;
                        }
                        case 8:
                        {
                            employee.InitDataEmployee();
                            employee.DisplayEmployee();
                            break;
                        }
                    case 9:
                        {
                            employee.CountEmployeeIDNamePosition();
                            break;
                        }
                    case 10:
                        {
                            employee.CountEmployee();
                            break;
                        }
                    case 12:
                        {
                            employee.ReadFile();
                            break;
                        }

                }
            }
        }
    }
}
