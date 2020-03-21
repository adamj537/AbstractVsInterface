using System;

namespace AbstractVsInterface
{
	/// <summary>
	/// Summary description for IEmployee.
	/// </summary>
	public interface IEmployee
	{
		// Fields aren't allowed in an interface.

		// just signature of the properties and methods.
		// setting a rule or contract to be followed by implementations.
		string ID
		{
			get;
			set;
		}

		string FirstName
		{
			get;
			set;
		}

		string LastName
		{
			get;
			set;
		}

		// cannot have implementation
		// cannot have modifiers public etc all are assumed public
		// cannot have virtual

		string Update();

		string Add();

		string Delete();

		string Search();

		string CalculateWage();
	}
}
