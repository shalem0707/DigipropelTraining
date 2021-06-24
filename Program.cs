using System;

namespace cSharp
{
    class Program
    {
      static int i,n,sum=0;
       
      public static void Main(String[] args)
        { 
         Console.WriteLine("Enter a number for pushing how many numbers");
         int a=int.Parse(Console.ReadLine());
         for(i=0;i<=a;i++){ 
           n=int.Parse(Console.ReadLine());
         sum=sum+n;
         }
         int div=sum/a;
         Console.WriteLine(div);
         }
    }    
         
  

}
