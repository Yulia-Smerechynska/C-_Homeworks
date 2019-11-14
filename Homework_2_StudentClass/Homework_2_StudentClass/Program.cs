using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ivanov", "Ivan", "Ivanovich", "MO-32", 26);
            student.FillGrades(Subjects.Programming, new List<int> { 5, 4, 3, 3 });
            student.FillGrades(Subjects.Administration, new List<int> { 4, 4, 4, 4 });
            student.FillGrades(Subjects.Design, new List<int> { 2, 2, 2, 3 });

            student.AddMark(Subjects.Design, 5);
            student.CalculateAverageMarkOfTheSubject(Subjects.Programming);
            int rez = student.GetMarkByIndex(Subjects.Programming, 8);


            string info = student.ToString();
            Console.WriteLine(info);
            student.PrintGrades();

            Console.ReadKey();
        }
           
          

}
    }

