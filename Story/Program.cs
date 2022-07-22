namespace Story
{
    class Program
    {
        static void Main()
        { 
            Console.WriteLine("What is your name ?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite color ?");
            var color = Console.ReadLine();

            Console.WriteLine("What is your favorite Animal ?");
            var animal = Console.ReadLine();

            Console.WriteLine("What is your favorite Band ?");
            var band = Console.ReadLine();

            Console.WriteLine($"Your favorite band {band} was being eaten by a {animal}, " +
                               $"{name} threw a granade that had {color} lasers emit and " + 
                               $"the {animal} ran off.");
        }           
    }
}