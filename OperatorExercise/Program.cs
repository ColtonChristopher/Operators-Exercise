
public class Program
{
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4)


                Console.WriteLine($"17/4 is 4 remainder 1");
        }
       static void AreaOfCircle(string[] args)
    {
        Console.WriteLine("What is the radius of your circle:");
        var radius = double.Parse(Console.ReadLine());
        double Area = Math.PI * radius * radius;
        Console.WriteLine("Area of circle: " + Area);
        Console.ReadKey();
    }