namespace GarageOv5
{
	internal class Bus : Vehicle
	{
		public int NumberOfSeats
		{
			get;
			set;
		}

		public Bus(int wheels, string color, int registration, int numberOfSeats)
			: base(wheels, color, registration)
		{
			NumberOfSeats = numberOfSeats;
		}

		public override string Stats()
		{
			return $"{base.Stats()} , Nr of Seats: {NumberOfSeats}";
		}
	}
}
