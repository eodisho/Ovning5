namespace GarageOv5
{
	internal abstract class Vehicle
	{
		public int Wheels
		{
			get;
			set;
		}

		public string Color
		{
			get;
			set;
		}

		public int Registration
		{
			get;
			set;
		}

		public Vehicle(int wheels, string color, int registration)
		{
			Wheels = wheels;
			Color = color;
			Registration = registration;
		}

		public virtual string Stats()
		{
			return $"Nr of Wheels: {Wheels}, Color: {Color}, RegNr: {Registration}";
		}
	}
}
