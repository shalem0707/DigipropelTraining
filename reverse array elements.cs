using System;

namespace assignmentc

{
  
class program {
 
    static public void Main()
    {
       int[] arr1=new int[]{2,3,5};
    int[] arr2=new int[arr1.Length];
    int j=0;
    
    for(int i = arr1.Length - 1; i >= 0; i--)
    {
     arr2[j] = arr1[i];
     j++;
    }
    Console.WriteLine("reversed array is");
    for(int i=0;i<j;i++){
            Console.WriteLine(arr2[i]);
    }
    }
}
}