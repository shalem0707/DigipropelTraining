using System;

namespace assignmentc
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] a=new int[]{1,2,2,2,3,3,3,4,5};
             int count=0;
             
            for(int i=0;i<=a.Length-1;i++)
            {
                for(int j=i+1;j<=a.Length-1;j++){
                if(a[i]==a[j]){
                    count=count+1;
                    break;
                }
              }
        }
        Console.WriteLine(count);
    }

    }
}