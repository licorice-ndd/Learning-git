using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ASS1_VER2
{
    internal class Employee
    {
        Validate vali = new Validate();
        List<Employee> listEmp = new List<Employee>();
        public int Id { get; set; }
        public string Name { get; set; }
        public double Basesalary { get; set; }
        public string Position { get; set; }

        public Employee() { }

        public Employee(int id, string name, double basesalary, string position)
        {
            Id = id;
            Name = name;
            Basesalary = basesalary;
            Position = position;
        }

        public void ReadFile()
        {
            string[] filecontent;
            filecontent = File.ReadAllLines(@"D:\Semester 10 PRN & PRY\ASS1 DuyNDSE05813\ASS1 VER2\ASS1 VER2\TextFile1.txt");
            for(int i = 0; i<filecontent.Length;i++)
            {
                Console.WriteLine("\t" + filecontent[i]);
            }
        }

        public void InitDataEmployee()
        {
            listEmp.Add(new Employee(1, "Dong", 1000, "Manager"));
            listEmp.Add(new Employee(2, "Tay", 2000, "Dev"));
            listEmp.Add(new Employee(3, "Nam", 3000, "Manager"));
            listEmp.Add(new Employee(4, "Bac", 4000, "Dev"));
        }
        public void DisplayEmployee()
        {
            for (int i = 0; i < listEmp.Count; i++)
            {
                Console.WriteLine(listEmp[i].ToString());
            }
        }
        public void CountEmployee()
        {
            Console.Write("Start salary : ");
            Double start = Validate.getInput();
            Console.Write("End salary : ");
            Double end = Validate.getInput();
            var betweensalary = new List<Employee>();
            foreach(var emp in listEmp)
            {
                if (emp.Basesalary >= start && emp.Basesalary < end) 
                {
                betweensalary.Add(emp);
                }
            }
            DisplayCountEmployee(betweensalary);
        }
        public void DisplayCountEmployee(List<Employee> listEmp)
        {
            foreach(var emp in listEmp) { Console.WriteLine(emp.ToString()); }  
        }

        public void CountEmployeeIDNamePosition()
        {
            int option;
            Console.WriteLine("9.1 By ID ? ");
            Console.WriteLine("9.2 By Name ? ");
            Console.WriteLine("9.3 By Position ? ");
            option = vali.GetInt(1, 3, "Choice de !! : ");
            switch (option)
            {
                case 1:
                    {
                        Console.Write("Enter ID want to find : ");
                        int foundid = Validate.getInput();
                        var result = from emp in listEmp where emp.Id == foundid select emp;
                        DisplayCountEmployee(result.ToList());
                        break;
                    }
                case 2:
                    {
                        string foundname = vali.GetString(0, 10, "Enter name want to find : "); 
                        var result = from emp in listEmp where emp.Name == foundname select emp;
                        DisplayCountEmployee(result.ToList());
                        break;
                    }
                case 3:
                    {
                        string foundPosition = vali.GetString(0, 10, "Enter position want to find : ");
                        var result = from emp in listEmp where emp.Position == foundPosition select emp;
                        DisplayCountEmployee(result.ToList());
                        break;
                    }
            }

        }

        /*        public bool CheckDuplicateID(int ID)
                {
                    foreach (Employee emp in listEmp)
                    {
                        if (emp.Id == ID)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                public void InputEmployee()
                {
                    bool flag = true;
                    while (flag)
                    {
                        int Id = vali.GetInt(0, 10, "Enter ID : ");
                        string Name = vali.GetString(0, 10, "Enter name : ");
                        double Salary = vali.GetInt(0, 10, "Enter Salary : ");
                        string Position = vali.GetString(0, 10, "Enter Position : ");
                        if (CheckDuplicateID(Id) == false)
                        {
                            listEmp.Add(new Employee(Id, Name, Salary, Position));
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("ID is duplicate please enter again");
                        }
                    }
                }*/
        public override string ToString()
        {
            return "" + Id + "|" + Name + "|" + Basesalary + "|" + Position;
        }
    }
}
