using static System.Convert;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        /* Console.WriteLine("Hello, World!");
         string[] name;
         string? password;
         do
         {
             Console.WriteLine("Enter Password");
             password = Console.ReadLine();

         }
         while (password != "pa$$word");
         Console.WriteLine("correct !");
         */

        /* double a = 1;  
         int b = (int)a;
         Console.WriteLine(b);*/


        /*  double a = 1;
          int b = ToInt32(a);
          Console.WriteLine($"a is {a} and b is {b}");*/

       /* double[] doubles = new[] { 10.90,88,98.00,76.09,77,98.00};

        foreach (double d in doubles) 
        {
          Console.WriteLine($"ToInt32 : {d} is {ToInt32(d)}");
        }*/

       /* int a = 1234;
        
        reverse(a);

         void reverse(int n)
        {
            int sum = a % 10;
            Console.WriteLine(sum);
             a = a/10;
            reverse(a);
        }*/

        int s =int.Parse("24");
        Console.WriteLine(s);

        Console.Write("How many eggs are there? ");
        string? input = Console.ReadLine();

        if (int.TryParse(input,out int count))
        {
            WriteLine($"there are {count} eggs");
        }

        unchecked
        {
            int y = int.MaxValue + 1;
          WriteLine($"Initial value: {y}");
            y--;
            WriteLine($"After decrementing: {y}");
            y--;
            WriteLine($"After decrementing: {y}");
        }

        // for (; ; );

        /*  int max = 500;
          for (byte i = 0; i < max; i++)
          {
        y = 2 + ++x;
              Console.WriteLine(i);
          }*/

        for (int i = 1; i < 100; i++) 
        {
            if (i%3 == 0)
            { 
             Console.Write("Fizz ,");
            }
            else if(i%5 == 0)
            {
                Console.Write("Buzz ,");
            }
            else 
            {
                Console.Write(i+",");
            }
        }
        
        string Line = new ('-',count:90);
        WriteLine(Line);

        for (int i = 1; i <= 10; i++)
        { 
          WriteLine($"3 * {i} = {3 * i}");
        }
    }
}