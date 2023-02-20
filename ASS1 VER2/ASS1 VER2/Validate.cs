using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1_VER2
{
    internal class Validate
    {
        public int GetInt(int min, int max, string mess)
        {
            int value;
            while (true)
            {
                try
                {
                    Console.Write(mess);
                    value = Convert.ToInt32(Console.ReadLine());
                    if (value < min || value > max) throw new OverflowException("Vuot qua pham vi cho phep");
                    return value;
                }
                catch (FormatException)
                {

                    Console.WriteLine("Nhap Sai Format . Vui long nhap lai !!!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("So nhap vao vuot qua pham vi cho phep . Nhap lai !!!!");
                }
            }
        }

        public static int getInput()
        {
            int numberValue = 0;
            bool condition = true;
            while (condition)
            {
                try
                {
                    string val = Console.ReadLine();
                    numberValue = Int32.Parse(val);
                    if (numberValue < 0)
                    {
                        Console.WriteLine("Too low");
                        condition = true;
                        continue;
                    }
                    condition = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Input again", e);
                    condition = true;
                }
            }
            return numberValue;
        }

        public string GetString(int minLength, int maxLength, string mess)
        {
            string value;
            while (true)
            {

                Console.Write(mess);
                value = Console.ReadLine().Trim();

                if (value.Length > minLength || value.Length < maxLength)
                {
                    return value;

                }
                else { Console.WriteLine("Do dai chuoi chua phu hop yeu cau.Nhap Lai : "); }

            }
        }

        public static DateTime getDateTime()
        {
            DateTime time = new DateTime();
            time = DateTime.Parse(Console.ReadLine());
            return time;
        }
    }
}
