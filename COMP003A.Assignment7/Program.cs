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

				if (choiceInput == "4")
				{
					Console.WriteLine("Program ended ");
					running = false;
				}

				Console.WriteLine();
			}
		}
	}
}
