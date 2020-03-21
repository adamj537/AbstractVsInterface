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
			get => _id;
			set => _id = value;
		}

		public override string FirstName
		{
			get { return _fname; }
			set { _fname = value; }
		}

		public override string LastName
		{
			get { return _lname; }
			set { _lname = value; }
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
		public override string CalculateWage()
		{
			return "Full time employee " + base._fname + " is calculated using the Abstract class...";
		}
	}
}
