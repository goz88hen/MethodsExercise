namespace MethodsExercise
{
    class program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine($"Hey there, what is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Cool {userName} - now what is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"Oooh {color} and what is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Okay, okay now who is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Name:{userName}");
            Console.WriteLine($"Favorite Band: {band}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Color: {color}");

            Console.WriteLine($"OMG! {userName}, your favorite animal, who is a {animal}; sounds way better than your favorite band {band}" +
                $" I mean your color is {color}. Which totally describes your taste in music; I have to say, MM BARF! EWW, AS IF! I AM WRITING A LETTER TO THE PRINCIPAL RIGHT NOW!");
        }
    }
}

