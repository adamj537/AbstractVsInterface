namespace AbstractExample
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonCalculate = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxHours = new System.Windows.Forms.TextBox();
			this.labelHours = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxHourlyIncome = new System.Windows.Forms.TextBox();
			this.textBoxSalariedIncome = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonCalculate
			// 
			this.buttonCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonCalculate.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.buttonCalculate, 2);
			this.buttonCalculate.Location = new System.Drawing.Point(64, 29);
			this.buttonCalculate.Name = "buttonCalculate";
			this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
			this.buttonCalculate.TabIndex = 0;
			this.buttonCalculate.Text = "Calculate";
			this.buttonCalculate.UseVisualStyleBackColor = true;
			this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.textBoxHours, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelHours, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.textBoxHourlyIncome, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxSalariedIncome, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.buttonCalculate, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(203, 110);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// textBoxHours
			// 
			this.textBoxHours.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.textBoxHours.Location = new System.Drawing.Point(92, 3);
			this.textBoxHours.Name = "textBoxHours";
			this.textBoxHours.Size = new System.Drawing.Size(100, 20);
			this.textBoxHours.TabIndex = 1;
			// 
			// labelHours
			// 
			this.labelHours.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelHours.AutoSize = true;
			this.labelHours.Location = new System.Drawing.Point(3, 6);
			this.labelHours.Name = "labelHours";
			this.labelHours.Size = new System.Drawing.Size(76, 13);
			this.labelHours.TabIndex = 2;
			this.labelHours.Text = "Hours Worked";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Hourly Income";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Salaried Income";
			// 
			// textBoxHourlyIncome
			// 
			this.textBoxHourlyIncome.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.textBoxHourlyIncome.Location = new System.Drawing.Point(92, 58);
			this.textBoxHourlyIncome.Name = "textBoxHourlyIncome";
			this.textBoxHourlyIncome.Size = new System.Drawing.Size(100, 20);
			this.textBoxHourlyIncome.TabIndex = 5;
			// 
			// textBoxSalariedIncome
			// 
			this.textBoxSalariedIncome.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.textBoxSalariedIncome.Location = new System.Drawing.Point(92, 85);
			this.textBoxSalariedIncome.Name = "textBoxSalariedIncome";
			this.textBoxSalariedIncome.Size = new System.Drawing.Size(100, 20);
			this.textBoxSalariedIncome.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(203, 110);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Income Calculator";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonCalculate;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox textBoxHours;
		private System.Windows.Forms.Label labelHours;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxHourlyIncome;
		private System.Windows.Forms.TextBox textBoxSalariedIncome;
	}
}

