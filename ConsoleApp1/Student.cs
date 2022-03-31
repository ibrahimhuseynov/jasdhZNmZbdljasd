using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public int No;
        public string Surname { get;set; }
        public  int _No;  
        public static  int StudentNoCount;
        public Student()
        {
            StudentNoCount++;
            _No = StudentNoCount;
            No = _No;
        }
     

    }
}
