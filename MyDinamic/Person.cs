﻿namespace MyDinamic
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return Name + ", " + Age.ToString();
        }
    }
}