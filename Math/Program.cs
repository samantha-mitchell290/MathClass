Main();

static void Main()
{
    Console.WriteLine("---Circle Area Calculator---");
    double radius;

    do
    {
        Console.WriteLine("Enter the radius (0 to exit)");
        radius = Convert.ToDouble(Console.ReadLine());
    } while (radius != 0);

    if(radius == 0)
    {
        Console.WriteLine("The area of the circle is: " + CircleArea(radius));
    }
    else
    {
        Environment.Exit(0);
    }
}

static double CircleArea(double radius)
{
    double area = Math.PI * (Math.Pow(radius, radius));

    return area;
}