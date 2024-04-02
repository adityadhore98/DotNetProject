using Operators;
using System;
using System.Security.Cryptography.X509Certificates;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        /* int a = 10;
         int b = ++a;
         Console.WriteLine(a);
         Console.WriteLine(b);*/

        /*int c = 10;

        c += 8;
        Console.WriteLine(c);

        static bool DoStuff()
        {
            Console.WriteLine("I am doing some stuff.");
            return true;
        }

        bool l = true;
        bool m = false;*/

        /* Console.WriteLine();
         Console.WriteLine($"l & DoStuff() = {l & DoStuff()}");
         Console.WriteLine($"m & DoStuff() = {m & DoStuff()}");
         Console.WriteLine(new string('-', 80));
         Console.WriteLine($"m & DoStuff() = {m & DoStuff()}");
         Console.WriteLine($"m && DoStuff() = {m && DoStuff()}");*/

        //  Console.WriteLine($"l and m = {l & m}");

        /*Console.WriteLine(new string('-', 80));

        int n = 10; // 00001010
        int o = 6; // 00000110
        Console.WriteLine($"left shift operator = {n << 3}");
        Console.WriteLine($"o = {o}");
        Console.WriteLine($"n & o = {n & o}"); 
        Console.WriteLine($"n | o = {n | o}");
        Console.WriteLine($"n ^ o = {n ^ o}");
        Console.WriteLine(new string('-', 80));*/
        /*

         int a = 10;
         int b = 6;
         Console.WriteLine(a & b); //false
         Console.WriteLine(b | a); //

         bool x = true;
         bool y = true;
         Console.WriteLine(x ^ y);
         Console.WriteLine(x && y); //false*/

        Animal?[] animals = new Animal?[]
        {
               new Cat{ Name="Minu",Born=new (year:2025,month:11,day:6),
                        Legs = 4,
                        IsDomestic=true,  
                      },
               null,
               new Cat{Name="chinu",Born=new (year:2025,month:11,day:6),
                        Legs = 8,
                        IsDomestic=false,
                      },
               new Spider { Name = "Sid Vicious", Born = DateTime.Today,
                            IsPoisionous = true},
               new Spider { Name = "Captain Furry", Born = DateTime.Today }
        };

        foreach (Animal? animal in animals)
        {
            /* Console.WriteLine("Enter number between 1 to 7");
             int number = Convert.ToInt32(Console.ReadLine());

             // int number = Random.Shared.Next(1, 7);
             Console.WriteLine($"my number is : {number}");*/

            string? message = animal switch
            {
                Cat fourLeggedCat when fourLeggedCat.Legs == 4
                   => $"the cat name {fourLeggedCat.Name} has four leg.",
                // break;
                Cat wildCat when wildCat.IsDomestic == false
                    => $"The non-domestic cat is named {wildCat.Name}.",
                Cat cat => $"The cat is named {cat.Name}.",
                Spider spider when spider.IsPoisionous
                => $"The {spider.Name} spider is poisonous. Run!",
                null
                => "The animal is null.",
                _
                => $"The animal named {animal.Name} is a {animal.GetType().Name}."

                /*switch (number)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        goto case 1;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    default:
                        Console.WriteLine("default");
                        break;*/
            };
           Console.WriteLine($"switch statement: {message}");
        }
        /* run:
        { 
           Console.WriteLine("run fast : ");
        }*/
    }
}