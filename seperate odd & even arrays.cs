using System;

namespace assignmentc

{
  
class program {
 
    static public void Main()
    {
        int[] arr = new int[] { 3,9,7,2,4,6,8 };
        int[] arr2 =new int[arr.Length];
        int[] arr3 =new int[arr.Length];
        int b=0,c=0;
    
        for(int i=0;i<=arr.Length-1;i++)
        {
            if(arr[i]%2==0){
                
                arr2[b]=arr[i];
                b++;
                
            }
            else{
                arr3[c]=arr[i];
            c++;
                
            }
        }
    Console.WriteLine("Even numbers =");
    for(int i=0;i<b;i++){
        Console.WriteLine(arr2[i]);
    }
    Console.WriteLine("Odd numbers=");
    for(int i=0;i<c;i++){
        Console.WriteLine(arr3[i]);
    }
        
    }
}
}