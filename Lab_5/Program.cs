//Var 19
using System;
public class Circle
{
    private double radius;
    public double Radius
    {
        get { return radius; }
        set
        {
            if (value >= 0)
                radius = value;
        }
    }
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }
}
public class Cone
{
    private double radius;
    private double height;
    public double Radius
    {
        get { return radius; }
        set
        {
            if (value >= 0) radius = value;
        }
    }
    public double Height
    {
        get { return height; }
        set
        {
            if (value >= 0) height = value;
        }
    }
    public double CalculateVolume()
    {
        return (Math.PI * radius * radius * height) / 3;
    }
}
class Program
{
    static void Main()
    {
        Circle circle = new Circle();
        Cone cone = new Cone();
        double radius;
        double height;
        Console.Write("Getting the area of a circle");
        Console.Write("\n\nEnter the radius of a circle: ");
        while (!double.TryParse(Console.ReadLine(), out radius) || radius < 0)
        {
            Console.WriteLine("Invalid value was entered. Radius can only be more than 0 and number.");
            Console.Write("Enter the radius of a circle: ");
        }
        circle.Radius = radius;
        Console.WriteLine($"The area of the circle with radius {circle.Radius} equals {circle.CalculateArea():F2}");
        Console.WriteLine($"The circumference of the circle with radius {circle.Radius} equals to {circle.CalculateCircumference():F2}");
        Console.Write("\nDo you want to continue and deal with a cone? (y/n)");

        char a = Convert.ToChar(Console.ReadLine());
        if (a == 'n') { }
        else if (a == 'y')
        {
            Console.Clear();
            Console.WriteLine("Getting the volume of a cone");
            Console.Write("\nEnter the radius of a cone: ");
            while (!double.TryParse(Console.ReadLine(), out radius) || radius < 0)
            {
                Console.WriteLine("Invalid value was entered. Radius can only be more than 0 and number.");
                Console.Write("Enter the radius of a cone: ");
            }
            cone.Radius = radius;
            Console.Write("Enter the height of the cone: ");
            while (!double.TryParse(Console.ReadLine(), out height) || height < 0)
            {
                Console.WriteLine("Invalid value was entered. Height can only be more than 0 and number.");
                Console.Write("Enter the height of a cone: ");
            }
            cone.Height = height;
            Console.WriteLine($"The volume of the cone with radius {cone.Radius} and height {cone.Height} equals to {cone.CalculateVolume():F2}");
            Console.ReadKey();
        }
        else
        {
            Console.Clear();
            Console.Write("Invalid input");
            Console.ReadKey();
        }
    }
}