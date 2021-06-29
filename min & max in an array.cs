using System;

namespace assignmentc

{
  
class program {
 
    static public void Main()
    { 
        int[] arr= new int[]{24,50,10};
        int temp;

        for(int i=0;i<arr.Length-1;i++){
            for(int j=i+1;j<arr.Length;j++){
                if(arr[i]>arr[j]){
                    temp=arr[i];
                    arr[i]=arr[j];
                    arr[j]=temp;

                }

            }
        }
            Console.WriteLine("Minimum number is = "+arr[0]);
            Console.WriteLine("Max number is = "+arr[arr.Length-1]);


    }
}
}
    

  
