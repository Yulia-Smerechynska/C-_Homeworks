using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Homework_2_StudentClass
{
    class Student
    {
        private readonly string _surname;
        private readonly string _firstName;
        private readonly string _patronymic;
        private readonly string _group;
        private readonly int _age;

        private Dictionary<string, List<int>> _grades = new Dictionary<string, List<int>>();
      

        public Student(string surname, string firstName, string patronymic, string group, int age)
        {
            this._surname = surname;
            this._firstName = firstName;
            this._patronymic = patronymic;
            this._group = group;
            this._age = age;

        }

        public void FillGrades(Subjects subject, List<int> marks)
        {
            switch (subject)
            {
                case Subjects.Programming:
                    _grades.Add("programming", marks);                   
                    break;
                case Subjects.Administration:
                    _grades.Add("administration", marks);
                    break;
                case Subjects.Design:
                    _grades.Add("design", marks);
                    break;
                default:
                    break;
            }

        }

        public void AddMark(Subjects subject, int mark)
        {
            switch (subject)
            {
                case Subjects.Programming:                   
                    _grades["programming"].Add(mark);
                    break;
                case Subjects.Administration:               
                    _grades["administration"].Add(mark);
                    break;
                case Subjects.Design:
                    _grades["design"].Add(mark);
                    break;
                default:
                    break;
            }

        }

        public int GetMarkByIndex(Subjects subject, int index)
        {
            try
            {
                switch (subject)
                {
                    case Subjects.Programming:
                        int markOfProgramming = _grades["programming"].ElementAt(index);
                        Console.WriteLine($"The searching mark in {subject} is {markOfProgramming}");
                        return markOfProgramming;                       
                    case Subjects.Administration:
                        int markOfAdministration = _grades["administration"].ElementAt(index);
                        Console.WriteLine($"The searching mark in {subject} is {markOfAdministration}");
                        return markOfAdministration;
                    case Subjects.Design:
                        int markOfDesign = _grades["design"].ElementAt(index);
                        Console.WriteLine($"The searching mark in {subject} is {markOfDesign}");
                        return markOfDesign;
                    default:
                        return 0;
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"The index {index} doesn`t exist");
            }
            return 0;
        }

        public void CalculateAverageMarkOfTheSubject(Subjects subject)
        {
            switch (subject)
            {
                case Subjects.Programming:
                    double resultOfProgramming = _grades["programming"].Average();
                    Console.WriteLine($"The avarage mark of the {subject} is {resultOfProgramming:N}");
                    break;
                case Subjects.Administration:
                    double resultOfAdministaration = _grades["administration"].Average();
                    Console.WriteLine($"The avarage mark of the {subject} is {resultOfAdministaration:N}");
                    break;
                case Subjects.Design:
                    double resultOfDesign = _grades["design"].Average();
                    Console.WriteLine($"The avarage mark of the {subject} is {resultOfDesign:N}");
                    break;
                default:
                    break;
            }

        }

        public override string ToString()
        {
            return $"Surname: {_surname}\nFirst Name: {_firstName}\nPatronymic: {_patronymic}\nGroup: {_group}\nAge: {_age}\n";
        }
        
        public void PrintGrades()
        {           

            foreach (var kvp in _grades)
            {
                Console.WriteLine(kvp.Key + " :" + string.Join(",", kvp.Value));
            }

        }
        

    }   
    
    enum Subjects : byte
    {
        Programming,
        Administration,
        Design
    };
}

