using System;

namespace cSharp
{
    class Program
    {
      static int i,n,mul=1;
       
      public static void Main(String[] args)
        { 

         Console.WriteLine("Enter number as input for multiplying of  numbers");
         int a=int.Parse(Console.ReadLine());

         for(i=1;i<=a;i++)
         { 
           Console.WriteLine("Number {0}:",i);
           n=int.Parse(Console.ReadLine());
           mul=mul*n;
         }
          Console.WriteLine("The multiplication of above numbers is"+"= "+mul);
         }
    }    

}
