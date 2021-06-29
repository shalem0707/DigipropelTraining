using System;   
    
    public class HelloWorld   
    {   
      static void Main(String[] args)    
        { 
             int[] a=new int[]{1,2,3,4,5,6,7,8};
             int sum=0;
             
            for(int i=0;i<=a.Length-1;i++)
            {
               sum=sum+a[i];

            }
            Console.WriteLine(sum);
        }
    }


