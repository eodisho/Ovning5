using System;

namespace GarageOv5
{
	internal class UserInterface
	{
		private GarageHandler gh;

		public UserInterface(int size)
		{
			gh = new GarageHandler(size);
		}

		public void MainMenu()
		{
			MainMenuOptions();
		}

		public void MainMenuOptions()
		{
			Console.Clear();
			char yourChar = ' ';
			bool choice = true;
			do
			{
				Console.WriteLine("\nWelcome to Edwar's Garage!\n");
				Console.WriteLine("Please choose one of the following options\n");
				Console.WriteLine("0 - Quit the program");
				Console.WriteLine("1 - Add a new vehicle");
				Console.WriteLine("2 - Print all vehicles");
				Console.WriteLine("3 - Find vehicle by color");
				Console.WriteLine("4 - Seed data");
				Console.WriteLine("5 - Remove a vehicle");
				Console.WriteLine("6 - Print vehicle statistics");
				Console.WriteLine("Please choose a number from the above main menu");
				switch (char.ToLower(Console.ReadKey().KeyChar))
				{
				case '0':
					choice = false;
					break;
				case '1':
					AddNewVehicle();
					break;
				case '2':
					gh.PrintAll();
					break;
				case '3':
				{
					Console.WriteLine("Type in the color of vehicle to find");
					string color = Console.ReadLine();
					gh.FindByColor(color);
					break;
				}
				case '4':
					gh.SeedData();
					break;
				case '5':
				{
					int regNr = Utils.AskForInt("\nWhich reg nr you want to remove?");
					gh.Remove(regNr);
					break;
				}
				case '6':
					gh.PrintStats();
					break;
				default:
					Console.WriteLine("Incorrect input, try again!");
					Console.WriteLine();
					break;
				}
			}
			while (choice);
		}

		public void AddNewVehicle()
		{
			char yourChar = ' ';
			bool choice = true;
			do
			{
				Console.WriteLine("\nWelcome to Edwar's Garage!\n");
				Console.WriteLine("Please choose one of the following options");
				Console.WriteLine("0 - To return to the main menu");
				Console.WriteLine("1 - Add a Car");
				Console.WriteLine("2 - Add a Bus");
				Console.WriteLine("3 - Add a Boat");
				Console.WriteLine();
				Console.WriteLine("Please choose the type of vehicle to park\n");
				switch (char.ToLower(Console.ReadKey().KeyChar))
				{
				case '0':
					choice = false;
					break;
				case '1':
				{
					int doors = Utils.AskForInt("\nHow many doors does the car have?");
					int wheels = Utils.AskForInt("How many wheels does the car have?");
					string color = Utils.AskForString("What color is the car?");
					int registration = Utils.AskForInt("What is the car registration number?");
					gh.Park(gh.CreateCar(doors, wheels, color, registration));
					choice = false;
					break;
				}
				case '2':
				{
					int wheels2 = Utils.AskForInt("\nHow many wheels does the Bus have?");
					string color2 = Utils.AskForString("What color is the Bus?");
					int registration2 = Utils.AskForInt("What is the Bus registration number?");
					int numberOfSeats = Utils.AskForInt("How many seats does the Bus have?");
					gh.Park(gh.CreateBus(wheels2, color2, registration2, numberOfSeats));
					choice = false;
					break;
				}
				case '3':
				{
					int wheels3 = Utils.AskForInt("\nHow many wheels does the boat have?");
					string color3 = Utils.AskForString("What is the boat color?");
					int registration3 = Utils.AskForInt("What is the boat registration number?");
					bool passengerShip = Utils.AskForBool("Is it a a passenger boat? write either Yes, No");
					bool sailBoat = Utils.AskForBool("Is it a a sail boat? type either write, No");
					gh.Park(gh.CreateBoat(wheels3, color3, registration3, passengerShip, sailBoat));
					choice = false;
					break;
				}
				default:
					Console.WriteLine("That was an incorrect input, try again!");
					Console.WriteLine();
					break;
				}
			}
			while (choice);
		}
	}
}
