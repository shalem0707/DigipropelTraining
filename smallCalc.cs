using System;

namespace cSharp
{
    class Program
    {   
        static int a,b,add,mul,sub,div;
        public static void Main(String[] args)
        {
         Console.WriteLine("Enter two numbers");
          int a= int.Parse(Console.ReadLine());
          int b=int.Parse(Console.ReadLine());

          Console.WriteLine("the result of two numbers is");
          add=a+b;
          mul=a*b;
          sub=a-b;
          div=a/b;
          Console.WriteLine(add+" "+mul+" "+sub+" "+div);

        }
    }
}