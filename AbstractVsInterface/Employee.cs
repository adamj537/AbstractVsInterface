using System;

namespace AbstractVsInterface
{
	/// <summary>
	/// An abstract class representing a generic employee.
	/// </summary>
	public abstract class Employee
	{
		#region Fields

		protected string _id;
		protected string _lname;
		protected string _fname;

		#endregion

		#region Properties

		public abstract string ID { get; set; }

		public abstract string FirstName { get; set; }
		
		public abstract string LastName { get; set; }

		#endregion

		#region Completed Methods

		public string Update()
		{
			return "Employee " + _id + " " + _lname + " " + _fname + " updated";
		}

		public string Add()
		{
			return "Employee " + _id + " " + _lname + " " + _fname + " added";
		}

		public string Delete()
		{
			return "Employee " + _id + " " + _lname + " " + _fname + " deleted";
		}
		
		public string Search()
		{
			return "Employee " + _id + " " + _lname + " " + _fname + " found";
		}

		#endregion

		#region Abstract Methods

		// This abstract method is different for Fulltime and Contractor.
		// Therefore it is uncompleted; each implementation 
		// completes it the way they calculate the wage.
		public abstract string CalculateWage();

		#endregion
	}
}
