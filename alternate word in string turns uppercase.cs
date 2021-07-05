using System;
 
namespace assignmentC
 
{
  
class program {
 
    static public void Main()
    {
      String name;
      
      Console.WriteLine("Enter a String");
      name=Console.ReadLine();
        char[] car=name.ToCharArray();
 
        
        for(int i=0;i<car.Length;i++)
        {
            if(car[i]==' ')
            {
                Console.WriteLine(" ");
            }
            else if(car[i]==','){
                Console.WriteLine(",");
            }
            else if(car[i]=='#'){
                Console.WriteLine("#");
            }
            else if(i%2==0){
                car[i]=char.ToUpper(car[i]);
            }
            else{
                car[i]=char.ToLower(car[i]);           
                 }
           
        }
    Console.WriteLine(car);
     
          
    }
}
}