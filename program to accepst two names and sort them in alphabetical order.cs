using System;
 
namespace assignmentC
 
{
  
class program {
 
    static public void Main()
    {
      String name1,name2;
      char temp;
 
        Console.WriteLine("Please enter names");
      name1=Console.ReadLine();
      name2=Console.ReadLine();
 
      name1.ToLower();
      name2.ToLower();
 
      
 
      char[] name=name1.ToCharArray();
      char[] fname=name2.ToCharArray();
 
      for(int i=0;i<=name.Length-1;i++){
        for(int j=i+1;j<=name.Length-1;j++){
              if(name[i]>name[j])
              {
                 temp=name[i];
                name[i]=name[j];
                name[j]=temp;
 
              }
        }
      }
      Console.WriteLine(name);
 
      for(int i=0;i<fname.Length;i++){
          for(int j=i+1;j<fname.Length;j++){
              if(fname[i]>fname[j]){
                  temp=fname[i];
                  fname[i]=fname[j];
                  fname[j]=temp;
              }
          }
          
      }
      Console.WriteLine(fname);
      
 
      
    }
}
}