namespace GetScore
{
	partial class getScore
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
			this.btGet = new System.Windows.Forms.Button();
			this.tbSBD = new System.Windows.Forms.TextBox();
			this.rtbSource = new System.Windows.Forms.RichTextBox();
			this.pgbget100 = new System.Windows.Forms.ProgressBar();
			this.lbGet100 = new System.Windows.Forms.Label();
			this.pgb1 = new System.Windows.Forms.ProgressBar();
			this.lb1 = new System.Windows.Forms.Label();
			this.pgb2 = new System.Windows.Forms.ProgressBar();
			this.lb2 = new System.Windows.Forms.Label();
			this.pgb3 = new System.Windows.Forms.ProgressBar();
			this.lb3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btGet
			// 
			this.btGet.Location = new System.Drawing.Point(130, 18);
			this.btGet.Name = "btGet";
			this.btGet.Size = new System.Drawing.Size(83, 31);
			this.btGet.TabIndex = 0;
			this.btGet.Text = "GET";
			this.btGet.UseVisualStyleBackColor = true;
			this.btGet.Click += new System.EventHandler(this.btGet_Click);
			// 
			// tbSBD
			// 
			this.tbSBD.Font = new System.Drawing.Font("SVN-Agency FB", 14.25F);
			this.tbSBD.Location = new System.Drawing.Point(12, 18);
			this.tbSBD.Name = "tbSBD";
			this.tbSBD.Size = new System.Drawing.Size(100, 31);
			this.tbSBD.TabIndex = 1;
			this.tbSBD.Text = "02000145";
			// 
			// rtbSource
			// 
			this.rtbSource.Location = new System.Drawing.Point(-1, 55);
			this.rtbSource.Name = "rtbSource";
			this.rtbSource.Size = new System.Drawing.Size(589, 42);
			this.rtbSource.TabIndex = 2;
			this.rtbSource.Text = "";
			// 
			// pgbget100
			// 
			this.pgbget100.Location = new System.Drawing.Point(-1, 103);
			this.pgbget100.Name = "pgbget100";
			this.pgbget100.Size = new System.Drawing.Size(510, 23);
			this.pgbget100.TabIndex = 3;
			// 
			// lbGet100
			// 
			this.lbGet100.AutoSize = true;
			this.lbGet100.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.lbGet100.Location = new System.Drawing.Point(528, 103);
			this.lbGet100.Name = "lbGet100";
			this.lbGet100.Size = new System.Drawing.Size(35, 24);
			this.lbGet100.TabIndex = 4;
			this.lbGet100.Text = "0/0";
			// 
			// pgb1
			// 
			this.pgb1.Location = new System.Drawing.Point(-1, 132);
			this.pgb1.Name = "pgb1";
			this.pgb1.Size = new System.Drawing.Size(510, 23);
			this.pgb1.TabIndex = 3;
			// 
			// lb1
			// 
			this.lb1.AutoSize = true;
			this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.lb1.Location = new System.Drawing.Point(528, 132);
			this.lb1.Name = "lb1";
			this.lb1.Size = new System.Drawing.Size(35, 24);
			this.lb1.TabIndex = 4;
			this.lb1.Text = "0/0";
			// 
			// pgb2
			// 
			this.pgb2.Location = new System.Drawing.Point(-1, 161);
			this.pgb2.Name = "pgb2";
			this.pgb2.Size = new System.Drawing.Size(510, 23);
			this.pgb2.TabIndex = 3;
			// 
			// lb2
			// 
			this.lb2.AutoSize = true;
			this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.lb2.Location = new System.Drawing.Point(528, 161);
			this.lb2.Name = "lb2";
			this.lb2.Size = new System.Drawing.Size(35, 24);
			this.lb2.TabIndex = 4;
			this.lb2.Text = "0/0";
			// 
			// pgb3
			// 
			this.pgb3.Location = new System.Drawing.Point(-1, 190);
			this.pgb3.Name = "pgb3";
			this.pgb3.Size = new System.Drawing.Size(510, 23);
			this.pgb3.TabIndex = 3;
			// 
			// lb3
			// 
			this.lb3.AutoSize = true;
			this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.lb3.Location = new System.Drawing.Point(528, 190);
			this.lb3.Name = "lb3";
			this.lb3.Size = new System.Drawing.Size(35, 24);
			this.lb3.TabIndex = 4;
			this.lb3.Text = "0/0";
			// 
			// getScore
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(608, 317);
			this.Controls.Add(this.lb3);
			this.Controls.Add(this.lb2);
			this.Controls.Add(this.lb1);
			this.Controls.Add(this.lbGet100);
			this.Controls.Add(this.pgb3);
			this.Controls.Add(this.pgb2);
			this.Controls.Add(this.pgb1);
			this.Controls.Add(this.pgbget100);
			this.Controls.Add(this.rtbSource);
			this.Controls.Add(this.tbSBD);
			this.Controls.Add(this.btGet);
			this.Name = "getScore";
			this.Text = "GetScore";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btGet;
		private System.Windows.Forms.TextBox tbSBD;
		private System.Windows.Forms.RichTextBox rtbSource;
		private System.Windows.Forms.ProgressBar pgbget100;
		private System.Windows.Forms.Label lbGet100;
		private System.Windows.Forms.ProgressBar pgb1;
		private System.Windows.Forms.Label lb1;
		private System.Windows.Forms.ProgressBar pgb2;
		private System.Windows.Forms.Label lb2;
		private System.Windows.Forms.ProgressBar pgb3;
		private System.Windows.Forms.Label lb3;
	}
}

