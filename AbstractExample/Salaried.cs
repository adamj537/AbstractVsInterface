namespace AbstractExample
{
	/// <summary>
	/// Class for a salaried employee.
	/// </summary>
	/// <remarks>
	/// Inheriting from the abstract class
	/// </remarks>
	public class Salaried : Employee
	{
		// Uses all the properties of the Abstract class, therefore no properties or fields here.

		public Salaried() { }

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
		public int Salary { get; set; }

		// Common methods that are implemented in the abstract class:

		public new string Add()
		{
			return base.Add();
		}

		public new string Delete()
		{
			return base.Delete();
		}

		public new string Search()
		{
			return base.Search();
		}

		// Abstract method that is different from Fulltime and Contractor,
		// and therefore is overridden here:
		public override int CalculateIncome(int hours)
		{
			int hourlyWage = Salary / 2080;

			return hours * hourlyWage;
		}
	}
}
