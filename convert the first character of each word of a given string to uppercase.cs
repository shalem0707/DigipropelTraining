using System;
 
namespace assignmentC
 
{
  
class program {
    static char[] a;
    static public void Main()
    {
      String name;
      
      Console.WriteLine("Enter a String");
      name=Console.ReadLine();
      String[] arr= name.Split(" ");
 
      for(int i=0;i<arr.Length;i++){
        a=arr[i].ToCharArray(); //a=p r a v e e n
        char b= Char.ToUpper(a[0]);//b=P
 
        String C= arr[i].Substring(1); //raveen
      Console.Write(b+C);//Praveen
       Console.Write(" "); 
      }
      
      
      
    }
}
}