using System;
using System.Collections.Generic;
namespace ArrayAndListExercises
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //MainClass.Exercise1();
            //MainClass.Exercise2();
            //MainClass.Exercise3();
            //MainClass.Exercise4();
            MainClass.Exercise5();
        }

        public static void Exercise1 () 
        {
            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Type a name (or hit ENTER to quit: ");

                var input = Console.ReadLine();
                if(String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                names.Add(input);
            }

			if (names.Count > 2)
            {
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            }
			else if (names.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            }
			else if (names.Count == 1)
            {
                Console.WriteLine("{0} likes your post.", names[0]);
            }
				
			else 
            {
                Console.WriteLine();
            }
				
        }

        public static void Exercise2 ()
        {
            Console.WriteLine("Please enter your name: ");

            var name = Console.ReadLine();
            var newArray = name.ToCharArray();  //like split in javascript
            Array.Reverse(newArray); //reverse the array
            var reversedString = new string(newArray); //change the array to a string

            Console.WriteLine(reversedString);  


        }

        public static void Exercise3 ()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
				Console.WriteLine("Please enter a number: ");
				var number = Convert.ToInt32(Console.ReadLine());

				if (numbers.Contains(number))
				{
					Console.WriteLine("You've previously entered " + number);
					continue;
				}

				numbers.Add(number);
            }

            numbers.Sort();

            foreach(var number in numbers)
            {
                Console.WriteLine("Your numbers in order are: ");
                Console.WriteLine(numbers);
            }

        }

        public static void Exercise4 ()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach(var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
            }

            Console.WriteLine("Unique numbers: ");
            foreach (var number in uniques)
            {
                Console.WriteLine(number);
            }
        }

        public static void Exercise5 ()
		{
			string[] elements;
			while (true)
			{
				Console.Write("Enter a list of comma-separated numbers: ");
				var input = Console.ReadLine();

				if (!String.IsNullOrWhiteSpace(input))
				{
					elements = input.Split(',');
					if (elements.Length >= 5)
						break;
				}

				Console.WriteLine("Invalid List");
			}

			var numbers = new List<int>();
			foreach (var number in elements)
				numbers.Add(Convert.ToInt32(number));

			var smallests = new List<int>();
			while (smallests.Count < 3)
			{
				// Assume the first number is the smallest
				var min = numbers[0];
				foreach (var number in numbers)
				{
					if (number < min)
						min = number;
				}
				smallests.Add(min);

				numbers.Remove(min);
			}

			Console.WriteLine("The 3 smallest numbers are: ");
			foreach (var number in smallests)
				Console.WriteLine(number);
		}
    }
}
