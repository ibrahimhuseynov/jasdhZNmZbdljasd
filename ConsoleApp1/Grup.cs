using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Type
    {
        Programming, 
        Design,
        System
    }
    internal class Grup :Student
    {
        public string No;
        private int _No=100;
        public Grup(Type Programming,Type System,Type Design)
        {
            _No++;
            switch (Type)
            {
                case Type.Programming:
                    No = $"P{_No}";
                    break;
                case Type.Design:
                    No = $"D{_No}";
                    break;
                case Type.System:
                    No = $"S{_No}";
                    break;
                default:
                    break;
            }

        }
        Student[] students = new Student[0];
        public static void FindStudentByNo(int b)
        {
            if (b == _No)
            {
                return Student.StudentNoCount();

            }
        }

    }
}
