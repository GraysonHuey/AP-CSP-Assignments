namespace Selection {
	static class Programs {
		public static void Divisible() {
			Console.Clear();
			
			Console.WriteLine("Enter your name:");
			string name = Console.ReadLine()!;

			Console.Clear();

			Console.WriteLine($"{name}, enter an integer:");
			int num1 = Convert.ToInt32(Console.ReadLine());

			Console.Clear();

			Console.WriteLine($"{name}, enter another integer:");
			int num2 = Convert.ToInt32(Console.ReadLine());

			Console.Clear();

			if (num1 % num2 == 0) {
				Console.WriteLine($"{num1} is divisible by {num2}.");
			} 
			else {
				Console.WriteLine($"{num1} is not divisible by {num2}.");
			}
			
			Thread.Sleep(3000);
			MainProgram.Program.Main();
		}

		public static string FormatDoubleWithCommas(double number)
		{
			return $"{number:#,0.00}";
		}

		public static void Geometry() {
			Random random = new Random();

			decimal smallNumber;
			decimal largeNumber;

			while (true)
			{
				try
				{
					Console.Clear();
					Console.Write("Enter a small decimal number: ");
					smallNumber = Convert.ToDecimal(Console.ReadLine());
					break;
				}
				catch (FormatException)
				{
					Console.Clear();
					Console.WriteLine("Please enter a number.\nPress any key to try again.");
					Console.ReadKey();
				}
			}

			while (true)
			{
				try
				{
					Console.Clear();
					Console.Write("Enter a large decimal number: ");
					largeNumber = Convert.ToDecimal(Console.ReadLine());
					break;
				}
				catch (FormatException)
				{
					Console.Clear();
					Console.WriteLine("Please enter a number.\nPress any key to try again.");
					Console.ReadKey();
				}
			}

			Console.Clear();

			decimal randomValue = (decimal)random.NextDouble() * (largeNumber - smallNumber) + smallNumber;

			double radius = Math.Round((double)randomValue, 2);
			double volume = Math.Round(4.0 / 3.0 * Math.PI * Math.Pow(radius, 3), 2);

			string x = volume.ToString();
			
			x = FormatDoubleWithCommas(volume);

			Console.WriteLine($"A sphere with a radius of {radius} has a volume of about {x}.\nPress any key to go back to the menu.");
			Console.ReadKey();
		}

		public static void Quiz() {
			Console.Clear();

			Console.WriteLine("Grass is green. True or False:");
			string input = Console.ReadLine()!;

			switch (input) {
				case "True":
				case "true":
				case "T":
				case "t":
					Console.Clear();
					Console.WriteLine("Correct, grass is green!");
					break;
	
				case "False":
				case "false":
				case "F":
				case "f":
					Console.Clear();
					Console.WriteLine("Incorrect, grass IS green.");
					break;
	
				default:
					Console.Clear();
					Console.WriteLine("Please input a valid answer.");
					Thread.Sleep(3000);
					Quiz();
					break;
			}

			Console.WriteLine("Press any key to continue.");
			Console.ReadKey();
			MainProgram.Program.Main();
		}

	}
}

namespace Iteration {
	static class Programs
	{
		public static void InputNum()
		{
			int userNum;
			
			Console.Clear();
			Console.WriteLine("Enter number");
			while (true)
			{
				try
				{
					userNum = Convert.ToInt32(Console.ReadLine()!);
					break;
				}
				catch (FormatException)
				{
				}
			}

			while (userNum > 100 || userNum < 1)
			{
				Console.Clear();
				Console.WriteLine("Invalid number. Press any key to try again.");
				Console.ReadKey();
				try
				{
					userNum = Convert.ToInt32(Console.ReadLine()!);
					break;
				}
				catch (FormatException)
				{
				}
			}
			Console.Clear();
			Console.WriteLine("Thank you for your input!\nPress any key to continue.");
			Console.ReadKey();
			MainProgram.Program.Main();
		}

		public static void GuessColor()
		{
			Console.Clear();
			Console.WriteLine("Guess my favorite color:");
			string guessColor = Console.ReadLine()!;
			string favColor = "purple";
			int tries = 1;
			while (guessColor != favColor)
			{
				Console.Clear();
				Console.WriteLine("Incorrect try again!");
				tries++;
				Thread.Sleep(1500);
				Console.Clear();
				Console.WriteLine("Guess my favorite color:");
				guessColor = Console.ReadLine()!;
			}
			Console.Clear();
			Console.WriteLine($"Correct! My favorite color is {favColor}!\nIt took you {tries} tries!\n\nPress any key to continue");
			Console.ReadKey();
			MainProgram.Program.Main();
		}

		public static void SumCalc()
		{
			int sum = 0;
			int amount;
			Console.Clear();
			Console.WriteLine("Enter the amount of numbers to sum:");
			while (true)
			{
				try
				{
					amount = Convert.ToInt32(Console.ReadLine());
					break;
				}
				catch (FormatException)
				{
				}
			}

			for (int i = 0; i < amount; i++)
			{
				int num = 0;
				Console.Clear();
				while (true)
				{
					try
					{
						num = Convert.ToInt32(Console.ReadLine());
						sum += num;
						break;
					}
					catch (FormatException)
					{
					}
				}
			}

			Console.Clear();
			Console.WriteLine($"The sum of your numbers is {sum}.\n\nPress any key to continue.");
			Console.ReadKey();
			MainProgram.Program.Main();
		}
	}
}

namespace MainProgram {
	static class Program {
		public static void Main() {
			string choice;
			string choice2;

			while (true) {
				Console.Clear();
				Console.WriteLine("1. Selection\n2. Iteration\n\nChoose an option:");
				choice = Console.ReadLine()!;
				
				switch (choice) {
					case "1":
					case "selection":
						while (true) {
							Console.Clear();
							Console.WriteLine("1. Divisible\n2. Geometry\n3. Quiz\n\nChoose an option:");
							choice2 = Console.ReadLine()!.ToLower();
							switch (choice2) {
								case "1":
								case "divisible":
									Selection.Programs.Divisible();
									break;
								case "2":
								case "geometry":
									Selection.Programs.Geometry();
									break;
								case "3":
								case "quiz":
									Selection.Programs.Quiz();
									break;
							}
							break;
						}
						break;
					case "2":
					case "iteration":
						while (true) {
							Console.Clear();
							Console.WriteLine("1. Input num\n2. Guess Color\n3. Sum Calculator\n\nChoose an option:");
							choice = Console.ReadLine()!.ToLower();
							switch (choice) {
								case "1":
								case "input":
									Iteration.Programs.InputNum();
									break;
								case "2":
								case "guess":
									Iteration.Programs.GuessColor();
									break;
								case "3":
								case "sum":
									Iteration.Programs.SumCalc();
									break;
							}
							break;
						}
						break;
				}
				
				break;
			}
		}
	}
}
