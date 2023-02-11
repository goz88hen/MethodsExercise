namespace MethodsExercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //--------Exercise 1-----------
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


            //--------Exercise 2-----------

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The Sum is : {sum}");

            Console.WriteLine("Give me a number to multiply");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
            int num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a third number to multiply");
            int num5 = int.Parse(Console.ReadLine());

            int multiply = Multiply(num3, num4, num5);
            Console.WriteLine($"The multiplcation is : {multiply}");

            Console.WriteLine("Give me a number to subtract");
            int num6 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to subtract to the first one");
            int num7 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a third number to subtract");
            int num8 = int.Parse(Console.ReadLine());

            int subtract = Subtract(num3, num4, num5);
            Console.WriteLine($"The subtraction equals to : {subtract}");


        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }


        public static int Multiply(int num3, int num4, int num5)
        {
            return num3 * num4 * num5;

        }
        public static int Subtract(int num6, int num7, int num8)
        {
            return num6 - num7 - num8;

            //----------Challenge---------


            int sum = Sum(2, 4);
            Console.WriteLine($"The Sum is : {sum}");


            static int Sum(params int[] list)
            {
                int sum = 0;
                for (int i = 0; i < list.Length; i++)
                {
                    sum = sum + list[i];
                }
                return sum;
                    }
        }
    }
}


            
    



    


        


