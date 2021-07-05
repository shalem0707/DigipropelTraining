using System;
 
namespace assignmentC
 
{
  
class program {
 
    static public void Main()
    {
      String name;
      
      Console.WriteLine("Enter a String");
      name=Console.ReadLine();
 
      String[] arr= name.Split(" ");
        
      
      
      Console.WriteLine("The number of word in the string are = "+arr.Length);
      
    }
}
}
 
    