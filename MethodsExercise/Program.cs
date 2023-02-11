namespace MethodsExercise
{
    class program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Who is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Name:{userName}");
            Console.WriteLine($"Favorite Band: (band)");
            Console.WriteLine($"Favorite Animal (animal)");
            Console.WriteLine($"Favorite Color (color)");
        }
    }
}

