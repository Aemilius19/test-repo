using ConsoleApp9.Model;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Emil");
            Student student2 = new Student("Ali");
            Student student3 = new Student("Rasul");

            Group  grup = new Group(105,10);
            grup.Addstudent(student1,1);
            grup.Addstudent(student2,2);
            grup.Addstudent(student3,3);
            grup.ShowAllStudent();

        }
    }
}