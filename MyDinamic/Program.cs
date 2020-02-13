using System;

namespace MyDinamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dynamic = 3;
            Console.WriteLine(dynamic);

            dynamic = "Privet";
            Console.WriteLine(dynamic);

            dynamic = new Person() {Name = "Tom", Age = 23 };
            Console.WriteLine(dynamic);
            Console.ReadKey();
        }
    }
}
