using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers.Task24._03._2022.Models
{
    class Person
    {
        private string _name;
        private string _surname;
        private int _age;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!(IsFirstUpperName(value) == true) || !(value.Length>=3)|| !(value.Length <= 30))
                {
                    Console.WriteLine("Please check name again.");
                    Console.WriteLine("******************************");
                    return;
                }
                _name = value;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (!(IsFirstUpperSurname(value) == true) || !(value.Length >= 3) || !(value.Length <= 35))
                {
                    Console.WriteLine("Please check surname again.");
                    Console.WriteLine("******************************");
                    return;
                }
                _surname = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public bool IsFirstUpperName(string name)
        {

            bool result = false;
            string newName="";


            newName = char.ToUpper(name[0]) + name.Substring(1);
            
            if (name == newName)
                result = true;

            return result;

        }
        public bool IsFirstUpperSurname(string surname)
        {



            bool result1 = false;
            string newSurname ="";


            
            newSurname = char.ToUpper(surname[0]) + surname.Substring(1);

            if (surname == newSurname)
                result1 = true;

            return result1;

        }


    }
}
