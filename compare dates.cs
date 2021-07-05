using System;

namespace assignmentC

{

class program {

static public void Main()
{
DateTime d1= new DateTime(2021,07,07,4,4,4);
Console.WriteLine(d1);
DateTime d2= new DateTime(2021,07,07,4,4,4);
Console.WriteLine(d2);
if(d1==d2)
{
Console.WriteLine("True");
}
else
{
Console.WriteLine("False");
}
}
}
}