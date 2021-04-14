using System;

namespace GarageOv5
{
	internal static class Utils
	{
		internal static string AskForString(string prompt)
		{
			bool success = false;
			string output = "";
			do
			{
				Console.WriteLine(prompt);
				output = Console.ReadLine();
				if (!string.IsNullOrEmpty(output) || !string.IsNullOrWhiteSpace(output))
				{
					success = true;
				}
			}
			while (!success);
			return output;
		}

		internal static bool AskForBool(string prompt)
		{
			bool success = false;
			bool output = false;
			do
			{
				string input = AskForString(prompt);
				if (input == "Yes" || input == "yes")
				{
					output = true;
					success = true;
					break;
				}
				if (input == "No" || input == "no")
				{
					output = false;
					success = true;
					break;
				}
				Console.WriteLine("Wrong format! Please write 'Yes' or 'No'.");
			}
			while (!success);
			return output;
		}

		internal static int AskForInt(string prompt)
		{
			bool success = false;
			int output = 0;
			do
			{
				string input = AskForString(prompt);
				success = int.TryParse(input, out output);
				if (!success)
				{
					Console.WriteLine("Wrong format! Is not an integer.");
				}
			}
			while (!success);
			return output;
		}
	}
}
