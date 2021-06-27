using System;

namespace cSharp
{
    class Program
    {
      static int i,n,avg=0;
       
      public static void Main(String[] args)
        { 

         Console.WriteLine("Enter number for Average of numbers");
         int a=int.Parse(Console.ReadLine());

         for(i=1;i<=a;i++)
         { 
           Console.WriteLine("Number {0}:",i);
           n=int.Parse(Console.ReadLine());
           avg=avg+n/a;
         }
          Console.WriteLine("The Average of above numbers is"+"= "+avg);
         }
    }    

}
