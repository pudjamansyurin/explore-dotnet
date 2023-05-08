using System;

namespace MyAppConsole;
class Program
{
    static void Main(string[] args)
    {
        DataStorage<string> ds = new DataStorage<string>(5);

        try
        {
            ds[0] = "Abdullah";
            ds[1] = "Pujakusuma";
            ds[2] = "Erawan";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i} => {ds[i]}");
            }
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
