using System;

namespace AbstractExample
{
	/// <summary>
	/// An abstract class representing a generic employee.
	/// </summary>
	public abstract class Employee
	{
		#region Fields

		protected int _id;
		protected string _lastName;
		protected string _firstName;
		protected string _password;

		#endregion

		#region Abstract Properties

		public abstract int ID { get; set; }
		public abstract string FirstName { get; set; }
		public abstract string LastName { get; set; }

		#endregion

		#region Other Properties

		public string Password
		{
			get { return _password; }
			set
			{
				if (value.Length < 6)
				{
					throw new Exception("Password must be at least six characters");
				}
				else
				{
					_password = value;
				}
			}
		}

		#endregion

		#region Completed Methods

		public string Login()
		{
			return "Employee " + _id + " " + _lastName + " " + _firstName + " updated";
		}

		public string Add()
		{
			return "Employee " + _id + " " + _lastName + " " + _firstName + " added";
		}

		public string Delete()
		{
			return "Employee " + _id + " " + _lastName + " " + _firstName + " deleted";
		}
		
		public string Search()
		{
			return "Employee " + _id + " " + _lastName + " " + _firstName + " found";
		}

		#endregion

		// This abstract method is different for Fulltime and Contractor.
		// Therefore it is uncompleted; each implementation 
		// completes it the way they calculate income.
		public abstract int CalculateIncome(int hours);
	}
}
