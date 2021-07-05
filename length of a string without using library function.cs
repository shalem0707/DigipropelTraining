using System;
 
namespace assignmentC
 
{
  
class program {
 
    static public void Main()
    {
      String name;
      int count=0;
      Console.WriteLine("Enter a String");
      name=Console.ReadLine();
      
      foreach(char characters in name){
          count=count+1;
      }
      Console.WriteLine("Count of the above string is"+count);
      
    }
}
}