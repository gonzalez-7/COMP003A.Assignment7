using System.Collections.Generic;

namespace COMP003A.Assignment7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* 
			The purpose of this program is to
			store and analyze the student scores using a repeating menu.
			*/
			// Collection Declaration: 
			List<int> scores = new List<int>() { 85, 90, 78, 92, 88 };

			bool running = true;

			// Menu loop

			while (running)
			{
				Console.WriteLine("1. Display Values");
				Console.WriteLine("2. Show Total");
				Console.WriteLine("3. Show Average");
				Console.WriteLine("4. Exit");
				Console.Write("Enter choice: ");

				string choiceInput = Console.ReadLine();

				if (choiceInput != "1" && choiceInput != "2" && choiceInput != "3" && choiceInput != "4")
				{
					Console.WriteLine("Invalid menu choice. Please enter a number from 1-4. ");
					Console.WriteLine();
					continue;
				}

				int choice = int.Parse(choiceInput);

				if (choice == 1)
				{
					//
				}

				else if (choice == 2)
				{
					//
				}

				else if (choice == 3)
				{
					//
				}

				else if (choice == 4)
				{
					Console.WriteLine("Program ended.");
					running = false;
				}

				Console.WriteLine();
				Console.WriteLine("Values:");

				foreach (int score in scores)
				{
					Console.WriteLine(score);
				}

				Console.WriteLine();

				int total = 0;

				for (int i = 0; i < scores.Count; i++)
				{
					total += scores[i];
				}

				Console.WriteLine();
				Console.WriteLine("Total: " + total);
				Console.WriteLine();
			}
		}
	}
}
