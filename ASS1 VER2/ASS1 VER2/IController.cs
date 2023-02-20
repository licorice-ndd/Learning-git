using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1_VER2
{
    internal interface IController
    {
        void InputCourse();
        void InputOnlineCourse();
        void DisplayCourse();
        void DisplayOnlineCourse();
        void SortCourse();
        void SortOnlineCourse();
        bool CheckDuplicateID(int ID);
        bool CheckDuplicateIDOnline(int ID);
    }
}
