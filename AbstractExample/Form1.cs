using System;
using System.Windows.Forms;

namespace AbstractExample
{
	/// <summary>
	/// Income calculator (to demonstrate an abstract class).
	/// </summary>
	/// <remarks>
	/// This example is a further-cleaned-up version of AbstractVsInterface
	/// which shows just the abstract class.
	/// </remarks>
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Create two employees and compute their incomes.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonCalculate_Click(object sender, EventArgs e)
		{
			int hours = Convert.ToInt32(textBoxHours.Text);

			// Create a salaried employee.
			Employee salariedPerson = new Salaried();

			salariedPerson.ID = 2234;
			salariedPerson.FirstName = "Rahman";
			salariedPerson.LastName = "Mahmoodi";
			((Salaried)salariedPerson).Salary = 45000;

			MessageBox.Show(salariedPerson.Add().ToString());

			textBoxSalariedIncome.Text = salariedPerson.CalculateIncome(hours).ToString();

			// Create an hourly employee.
			Employee hourlyPerson = new Hourly();

			hourlyPerson.ID = 9876;
			hourlyPerson.FirstName = "Adam";
			hourlyPerson.LastName = "Johnson";
			((Hourly)hourlyPerson).Wage = 25;

			MessageBox.Show(hourlyPerson.Add().ToString());

			textBoxHourlyIncome.Text = hourlyPerson.CalculateIncome(hours).ToString();
		}
	}
}
