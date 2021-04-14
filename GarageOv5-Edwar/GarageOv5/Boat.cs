namespace GarageOv5
{
	internal class Boat : Vehicle
	{
		public bool PassengerShip
		{
			get;
			set;
		}

		public bool SailBoat
		{
			get;
			set;
		}

		public Boat(int wheels, string color, int registration, bool passengerShip, bool sailBoat)
			: base(wheels, color, registration)
		{
			PassengerShip = passengerShip;
			SailBoat = sailBoat;
		}

		public override string Stats()
		{
			return base.Stats() + ", Passenger Ship: " + PassengerShip + ", Sail boat: " + SailBoat;
		}
	}
}
