class Program
{
    static void Main(string[] args)
    {
        List<Weight> weights = new List<Weight>
        {
            new Weight { Mass = 10, Color = ConsoleColor.Red, Size = 5 },
            new Weight { Mass = 5, Color = ConsoleColor.Green, Size = 3 },
            new Weight { Mass = 8, Color = ConsoleColor.Blue, Size = 4 },
            new Weight { Mass = 3, Color = ConsoleColor.Yellow, Size = 2 },
            new Weight { Mass = 12, Color = ConsoleColor.Magenta, Size = 6 }
        };

        Console.WriteLine("Sorted by Mass:");
        weights.Sort();
        foreach (Weight weight in weights)
        {
            Console.WriteLine($"Mass: {weight.Mass}, Color: {weight.Color}, Size: {weight.Size}");
        }

        Console.WriteLine("\nSorted by Size:");
        weights.Sort((x, y) => x.Size.CompareTo(y.Size));
        foreach (Weight weight in weights)
        {
            Console.WriteLine($"Mass: {weight.Mass}, Color: {weight.Color}, Size: {weight.Size}");
        }

        Console.WriteLine("\nSorted by Color:");
        weights.Sort((x, y) => x.Color.CompareTo(y.Color));
        foreach (Weight weight in weights)
        {
            Console.WriteLine($"Mass: {weight.Mass}, Color: {weight.Color}, Size: {weight.Size}");
        }

        Console.ReadLine();
    }
}