using AccessModifiers.Task24._03._2022.Models;
using System;

namespace AccessModifiers.Task24._03._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the name: ");
            string name = Console.ReadLine();
            
            Console.Write("Please enter surname: ");
            string surname = Console.ReadLine();

            Console.Write("Please enter the age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Please enter the point: ");
            double point = int.Parse(Console.ReadLine());

            Console.Clear();

            Student stu1 = new Student(name,age, point);
            
            stu1.Surname = surname;
            stu1.GetInfo();
        }
    }
}
