namespace AbstractExample
{
	/// <summary>
	/// Class for an hourly employee.
	/// </summary>
	/// <remarks>
	/// Inheriting from the abstract class
	/// </remarks>
	public class Hourly : Employee
	{
		// Properties from the abstract class.
		public override int ID
		{
			get => _id;
			set => _id = value;
		}

		public override string FirstName
		{
			get => _firstName;
			set => _firstName = value;
		}

		public override string LastName
		{
			get => _lastName;
			set => _lastName = value;
		}

		// Property unique to the derived class.
		public int Wage { get; set; }

		// Method which differs between derived classes.
		public override int CalculateIncome(int hours)
		{
			return Wage * hours;
		}
	}
}
