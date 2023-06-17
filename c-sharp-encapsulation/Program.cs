using c_sharp_encapsulation;
using System.Xml.Linq;
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

        WriteLine("###########################################");
        Employee employee = new Employee(19987,"omran", "engineer", 1433);
        employee.PrintEmployeeDetails();
        employee.UpdatePosition("manager");
        employee.UpdateSalary(2500);
        WriteLine("AFTER UPDATE: ");
        employee.PrintEmployeeDetails();
    }

   
    





}