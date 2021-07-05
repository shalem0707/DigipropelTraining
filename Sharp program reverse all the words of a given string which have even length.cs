using System;
 
namespace assignmentC
 
{
  
class program {
 
    static public void Main()
    {
      String name;
      
      Console.WriteLine("Enter a String");
      name=Console.ReadLine();
      String[] str=name.Split(" ");
 
    for(int i=0;i<str.Length;i++){
      if(str[i].Length%2==0){
          char[] car=str[i].ToCharArray();
         
        Array.Reverse(car);
        Console.Write(new string(car));
        Console.Write(" ");
      }
      else{
          Console.Write(str[i]);
          Console.Write(" ");
      }
 
    }
    
          
    }
}
}