namespace AbstractVsInterface
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
			this.buttonInterface = new System.Windows.Forms.Button();
			this.buttonAbstract = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonInterface
			// 
			this.buttonInterface.AutoSize = true;
			this.buttonInterface.Location = new System.Drawing.Point(13, 13);
			this.buttonInterface.Name = "buttonInterface";
			this.buttonInterface.Size = new System.Drawing.Size(102, 23);
			this.buttonInterface.TabIndex = 0;
			this.buttonInterface.Text = "Interface Example";
			this.buttonInterface.UseVisualStyleBackColor = true;
			this.buttonInterface.Click += new System.EventHandler(this.buttonInterface_Click);
			// 
			// buttonAbstract
			// 
			this.buttonAbstract.AutoSize = true;
			this.buttonAbstract.Location = new System.Drawing.Point(13, 43);
			this.buttonAbstract.Name = "buttonAbstract";
			this.buttonAbstract.Size = new System.Drawing.Size(99, 23);
			this.buttonAbstract.TabIndex = 1;
			this.buttonAbstract.Text = "Abstract Example";
			this.buttonAbstract.UseVisualStyleBackColor = true;
			this.buttonAbstract.Click += new System.EventHandler(this.buttonAbstract_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(174, 88);
			this.Controls.Add(this.buttonAbstract);
			this.Controls.Add(this.buttonInterface);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonInterface;
		private System.Windows.Forms.Button buttonAbstract;
	}
}

