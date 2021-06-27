using System;
namespace cSharp
{
    class Program
    {
        static int a,b=0,n;
        public static void Main(String[] args)
        {
          
           Console.WriteLine("Enter the Number for Input of Numbers");
           a =int.Parse(Console.ReadLine());
           for(int i=1;i<=a;i++)
           {
               Console.WriteLine("Number {0}:",i);
               n = int.Parse(Console.ReadLine());
               b=b+n;
           }
           if(n == n )
           {
               Console.WriteLine(b*3);  
           }
          
     }
    }
}