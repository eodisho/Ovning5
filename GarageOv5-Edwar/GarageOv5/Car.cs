namespace GarageOv5
{
	internal class Car : Vehicle
	{
		public int Doors
		{
			get;
			set;
		}

		public Car(int doors, int wheels, string color, int registeration)
			: base(wheels, color, registeration)
		{
			Doors = doors;
		}

		public override string Stats()
		{
			return "Nr of Doors:" + Doors + ", " + base.Stats();
		}
	}
}
