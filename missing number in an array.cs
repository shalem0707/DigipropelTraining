using System;

namespace assignmentc
{
    class Program
    {
        static void Main(string[] args)
        {
            int status =0;
            int[] a = {1,2,3,4,5,6,7,10 };
            for(int i=1;i<=10;i++){
                for(int j=0;j<=a.Length-1;j++)
                {
                    if(i==a[j]){
                        status=1;
                        break;
                    }
                
                else{
                    status=0;
                }
                }
            if(status==0){
                Console.WriteLine(i);
            }
            }
    
    }
    }
}