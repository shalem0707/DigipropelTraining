using System;

namespace cSharp
{
    class Program
    {
        static int a,b;
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Two Numbers");
            int a= int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());

            if((a>=0&&b<=0)||(a<=0&&b>=0){
                Console.WriteLine("True");
            }
            else{
                Console.WriteLine("False"); 
            }
        
        }
    }
}