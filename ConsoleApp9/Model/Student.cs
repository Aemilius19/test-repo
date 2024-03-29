using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Model
{
   public class Student
    {
        public string Fullname;
        public byte GroupNo;
        public double Avgpoint;
        public Student(string fullname)
        {
            Fullname = fullname;
        }
    }
}
