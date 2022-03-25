using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers.Task24._03._2022.Models
{
    class Student:Person
    {
        private double _point;

        public double Point
        {
            get
            {
                return _point;
            }
            set
            {
                if (!(value >= 0) || !(value <= 100))
                {
                    Console.WriteLine("Point is not specified range");
                    Console.WriteLine("******************************");
                    return;
                }
                _point = value;
            }
        }

        public Student(string name, int age, double point) :base(name,age)
        {
            Point = point;
        }

        public void GetInfo() 
        {
            Console.WriteLine($"Name: {Name} \n" +
                $"Surname: {Surname} \n" +
                $"Age: {Age} \n" +
                $"Point: {Point}");
        }
    }
}
    

    