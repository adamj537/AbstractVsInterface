using System;

namespace AbstractVsInterface
{
	/// <summary>
	/// Summary description for Emp_Fulltime.
	/// </summary>

	// Inheriting from the Abstract class
	public class EmployeeFulltime : Employee
	{
		// Uses all the properties of the Abstract class, therefore no properties or fields here.

		public EmployeeFulltime()
		{
		}

		public override string ID
		{
			get => id;
			set => id = value;
		}

		public override string FirstName
		{
			get { return fname; }
			set { fname = value; }
		}

		public override string LastName
		{
			get { return lname; }
			set { lname = value; }
		}

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

		public new string Update()
		{
			return base.Update();
		}
		
		// Abstract method that is different from Fulltime and Contractor,
		// and therefore is overridden here:
		public override String CalculateWage()
		{
			return "Full time employee " + base.fname + " is calculated using the Abstract class...";
		}
	}
}
