using System;
namespace program
{
class Program
 {
static void Main(string[] args)
 {
person trump=new person();
trump.greet(); //hello
student varun=new student();
varun.greet();//hello
varun.setAge(23);//set age
varun.showAge(18);//show age
professor te=new professor();
te.setAge(34);
te.greet();
te.explain();
 
//Console.WriteLine(age);
 
 
 }
 }
class person
 {
public void greet()
 {
Console.WriteLine("hello");
 }
public int setAge(int age)
 {
//int age=int.Parse(Console.ReadLine());
Console.WriteLine(age);
return age;
 }
 
 }
class student:person
 {
public void study()
 {
Console.WriteLine("i am Studying");
 }
public void showAge( int age)
 {
person ss=new person();
 
Console.WriteLine("My age is years old "+age);
 
 }
 }
class professor:person
 {
public void explain()
 {
Console.WriteLine("i am explaining on the screen");
 }
 }
 }