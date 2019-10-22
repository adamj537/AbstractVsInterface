using System;
using System.Windows.Forms;

namespace AbstractVsInterface
{
	/// <remarks>
	/// This example is a cleaned-up version copied from here:
	/// https://www.codeproject.com/Articles/11155/Abstract-Class-versus-Interface
	/// Its purpose is to show the differnce between an abstract class and an interface.
	/// </remarks>
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonInterface_Click(object sender, EventArgs e)
		{
			// Create an employee object using the employee interface.
			IEmployee employee;
			EmployeeFulltime2 emp1 = new EmployeeFulltime2();

			// A cast is required because of the interface.
			employee = (IEmployee)emp1;
			employee.ID = "2234";
			employee.FirstName = "Rahman";
			employee.LastName = "Mahmoodi";

			MessageBox.Show(employee.Add().ToString());

			MessageBox.Show(employee.CalculateWage().ToString());
		}

		private void buttonAbstract_Click(object sender, EventArgs e)
		{
			// Create an employee object.
			Employee employee = new EmployeeFulltime();

			employee.ID = "2234";
			employee.FirstName = "Rahman";
			employee.LastName = "Mahmoodi";

			MessageBox.Show(employee.Add().ToString());

			MessageBox.Show(employee.CalculateWage().ToString());
		}
	}
}
