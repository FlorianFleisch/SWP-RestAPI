﻿namespace MyEFCoreApp
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public City City { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
