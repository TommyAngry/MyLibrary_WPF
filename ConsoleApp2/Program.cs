

using MyLibrary_WPF;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
        Calculations calculation = new Calculations();

        TimeSpan time = new TimeSpan(10, 0, 00);
        TimeSpan time_2 = new TimeSpan(0, 30, 00);
        TimeSpan timeSuma = time + time_2;

        Console.WriteLine(timeSuma.Hours + " " + timeSuma.Minutes + " " + timeSuma.Seconds);
    }
}