using System;

namespace AbstractVsInterface
{
	/// <summary>
	/// Summary description for Emp_fulltime2.
	/// </summary>
	
	// Implementing the interface
	public class EmployeeFulltime2 : IEmployee
	{
		// All the properties and fields are defined here!
		protected string id;
		protected string lname;
		protected string fname;

		public EmployeeFulltime2()
		{
		}

		public string ID
		{
			get
			{
				return id;
			}
			set
			{
				id = value;
			}
		}
		
		public string FirstName
		{
			get
			{
				return fname;
			}
			set
			{
				fname = value;
			}
		}

		public string LastName
		{
			get
			{
				return lname;
			}
			set
			{
				lname = value;
			}
		}

		// All the manipulations including Add,Delete, Search, Update, Calculate are done
		// within the object as there are not implementation in the Interface entity.
		public string Add()
		{
			return "Fulltime Employee " + fname + " added.";
		}

		public string Delete()
		{
			return "Fulltime Employee " + fname + " deleted.";
		}

		public string Search()
		{
			return "Fulltime Employee " + fname + " searched.";
		}

		public string Update()
		{
			return "Fulltime Employee " + fname + " updated.";
		}
		
		// If you change to Calculatewage(). Just small 'w' it will raise error as in interface
		// it is CalculateWage() with capital 'W'.
		public string CalculateWage()
		{
			return "Full time employee " + fname + " calculated using Interface.";
		}
	}
}
