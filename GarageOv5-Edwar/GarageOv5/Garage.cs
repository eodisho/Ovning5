using System;
using System.Collections;
using System.Collections.Generic;

namespace GarageOv5
{
	internal class Garage<T> : IEnumerable<T>, IEnumerable where T : Vehicle
	{
		private T[] vehicles;

		public int Size => vehicles.Length;

		public T this[int index] => vehicles[index];

		public Garage(int size)
		{
			vehicles = new T[size];
		}

		public IEnumerator<T> GetEnumerator()
		{
			T[] array = vehicles;
			foreach (T vehicle in array)
			{
				if (vehicle != null)
				{
					yield return vehicle;
				}
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public bool IsEmpty()
		{
			T[] array = vehicles;
			foreach (T item in array)
			{
				if (item != null)
				{
					return false;
				}
			}
			return true;
		}

		public bool Add(T v)
		{
			for (int i = 0; i < vehicles.Length; i++)
			{
				if (vehicles[i] == null)
				{
					vehicles[i] = v;
					return true;
				}
			}
			Console.WriteLine("There is no space left in the garage!");
			return false;
		}

		public bool Remove(int regNr)
		{
			for (int i = 0; i < vehicles.Length; i++)
			{
				if (vehicles[i] != null && vehicles[i].Registration == regNr)
				{
					Console.WriteLine($"A vehicale with regNr {vehicles[i].Registration} was removed!");
					vehicles[i] = null;
					return true;
				}
			}
			Console.WriteLine("No such regNr exists");
			return false;
		}

		public bool FindByRegNr(int regNr)
		{
			for (int i = 0; i < vehicles.Length; i++)
			{
				if (vehicles[i] != null && vehicles[i].Registration == regNr)
				{
					Console.WriteLine($"registration nr {regNr} found!");
					return true;
				}
			}
			Console.WriteLine($"registration nr {regNr} not found!");
			return false;
		}
	}
}
