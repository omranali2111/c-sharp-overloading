internal class Program
{
    private static void Main(string[] args)
    {

       // Console.WriteLine("enter firs num");
       //double x=double.Parse(Console.ReadLine());
       // Console.WriteLine("enter second num");
       // double y = double.Parse(Console.ReadLine());

        Console.WriteLine( add(2, 3));
        Console.WriteLine(add(2.5, 3.2,2.3));
        Console.WriteLine(add(2, 3, 2));

    }


    static int add(int x, int y)
    {
        return x + y;
    }
    static int add(int x, int y,int z)
    {
        return x + y + z;
    }

    static double add(double x, double y, double z)
    {
        return x + y + z;
    }
}