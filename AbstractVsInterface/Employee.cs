using System;

namespace AbstractVsInterface
{
	/// <summary>
	/// An abstract class representing a generic employee.
	/// </summary>
	public abstract class Employee
	{
		#region Fields

		protected String id;
		protected String lname;
		protected String fname;

		#endregion

		#region Properties

		public abstract string ID
		{
			get;
			set;
		}

		public abstract string FirstName
		{
			get;
			set;
		}
		
		public abstract string LastName
		{
			get;
			set;
		}

		#endregion

		#region Completed Methods

		public string Update()
		{
			return "Employee " + id + " " + lname + " " + fname + " updated";
		}

		public string Add()
		{
			return "Employee " + id + " " + lname + " " + fname + " added";
		}

		public string Delete()
		{
			return "Employee " + id + " " + lname + " " + fname + " deleted";
		}
		
		public string Search()
		{
			return "Employee " + id + " " + lname + " " + fname + " found";
		}

		#endregion

		#region Abstract Methods

		// This abstract method is different for Fulltime and Contractor.
		// Therefore it is uncompleted; each implementation 
		// completes it the way they calculate the wage.
		public abstract String CalculateWage();

		#endregion
	}
}
