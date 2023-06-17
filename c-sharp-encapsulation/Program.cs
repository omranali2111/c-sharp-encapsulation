using c_sharp_encapsulation;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        Person person1=new Person("omran",27,"seeb");
    
        person1.SetName("ali");
        person1.PrintPersonDetails();

        WriteLine("###########################################");
        Rectangle rectangle = new Rectangle(3.2, 4.3);
        rectangle.PrintRectangleDetails();
    }

   
    





}