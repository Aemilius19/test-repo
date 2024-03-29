using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Model
{
    public class Group
    {
        public byte GroupNum;
        Student[] students;
        byte _studentlimit=10;
        public Group(byte groupNum, byte studentlimit)
        {
            GroupNum = groupNum;
            Studentlimit = studentlimit;
            students = new Student[0];
        }

        public byte Studentlimit 
        {
            get { return _studentlimit; }
            set 
            {
                if (value>0)
                {
                    _studentlimit = value;
                }
                else
                {
                    Console.WriteLine("limit sifirdan az ola bilmez");
                }
            }
        }

        public void Addstudent(Student student,byte studentlimit)
        {

            if (studentlimit<_studentlimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Limiti kecdiz");
            }
        }

        public void ShowAllStudent()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{GroupNum} nomreli grupun - {student.Fullname} telebesi");
            }
        }

    }
}
