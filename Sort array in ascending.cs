using System;
class HelloWorld {
  static void Main() {
    int[] arr1=new int[]{2,3,5,4};
    int temp;
    
    for(int i=0;i<arr1.Length-1;i++)
    {
        for(int j=i+1;j<arr1.Length;j++){
        if (arr1[i] > arr1[j]) 
        {
  
            temp = arr1[i];
            arr1[i] = arr1[j];
             arr1[j] = temp;
        }
        }
        }
         foreach(int items in arr1)
        {
            Console.Write(items + " ");
        }
  }
}