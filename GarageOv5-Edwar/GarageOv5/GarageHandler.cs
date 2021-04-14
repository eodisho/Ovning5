using System;

namespace GarageOv5
{
	internal class GarageHandler
	{
		private Garage<Vehicle> garage;

		public GarageHandler(int size)
		{
			garage = new Garage<Vehicle>(size);
		}

		public bool CheckVehicle(Vehicle vehicle)
		{
			foreach (Vehicle v in garage)
			{
				if (v.Registration == vehicle.Registration)
				{
					return true;
				}
			}
			return false;
		}

		public void Park(Vehicle vehicle)
		{
			if (!CheckVehicle(vehicle))
			{
				garage.Add(vehicle);
			}
			else
			{
				Console.WriteLine("Vehicle with same licence number already parked!");
			}
		}

		public void PrintAll()
		{
			if (garage.IsEmpty())
			{
				Console.WriteLine("\nThere are no vehicles in the garage");
				return;
			}
			foreach (Vehicle item in garage)
			{
				Console.WriteLine("\nVehicle type: " + item.GetType().Name + ", " + item.Stats());
			}
		}

		public void Remove(int regNr)
		{
			garage.Remove(regNr);
		}

		public void FindByRegNr(int regNr)
		{
			garage.FindByRegNr(regNr);
		}

		public void PrintStats()
		{
			int sumCar = 0;
			int sumBus = 0;
			int sumBoat = 0;
			foreach (Vehicle v in garage)
			{
				if (v.GetType().Name == "Car")
				{
					sumCar++;
				}
				if (v.GetType().Name == "Bus")
				{
					sumBus++;
				}
				if (v.GetType().Name == "Boat")
				{
					sumBoat++;
				}
			}
			Console.WriteLine($"\nCar: {sumCar}");
			Console.WriteLine($"Bus: {sumBus}");
			Console.WriteLine($"Boat: {sumBoat}");
		}

		public void FindByColor(string color)
		{
			int sum = 0;
			foreach (Vehicle v in garage)
			{
				if (v.Color.ToLower() == color)
				{
					sum++;
					Console.WriteLine($" {sum} vehicle/s with {color} color was/were found");
				}
			}
			if (sum == 0)
			{
				Console.WriteLine("No Vehicle with " + color + " color was found");
			}
		}

		public void SeedData()
		{
			Vehicle c1 = CreateCar(4, 4, "Black", 1);
			Vehicle c2 = CreateCar(6, 6, "Blue", 5);
			Vehicle c3 = CreateBus(6, "Orange", 2, 60);
			Vehicle c4 = CreateBoat(2, "White", 3, passengerShip: true, sailBoat: false);
			Park(c1);
			Park(c2);
			Park(c3);
			Park(c4);
		}

		public Vehicle CreateCar(int doors, int wheels, string color, int registeration)
		{
			return new Car(doors, wheels, color, registeration);
		}

		public Vehicle CreateBus(int wheels, string color, int registration, int numberOfSeats)
		{
			return new Bus(wheels, color, registration, numberOfSeats);
		}

		public Vehicle CreateBoat(int wheels, string color, int registration, bool passengerShip, bool sailBoat)
		{
			return new Boat(wheels, color, registration, passengerShip, sailBoat);
		}
	}
}
