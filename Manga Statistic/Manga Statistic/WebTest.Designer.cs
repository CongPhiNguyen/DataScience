namespace Manga_Statistic
{
	partial class WebTest
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
			this.rtbSource = new System.Windows.Forms.RichTextBox();
			this.btGetDetail = new System.Windows.Forms.Button();
			this.rtbDetail = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// btGet
			// 
			this.btGet.Location = new System.Drawing.Point(12, 2);
			this.btGet.Name = "btGet";
			this.btGet.Size = new System.Drawing.Size(75, 31);
			this.btGet.TabIndex = 1;
			this.btGet.Text = "Get";
			this.btGet.UseVisualStyleBackColor = true;
			this.btGet.Click += new System.EventHandler(this.btGet_Click);
			// 
			// rtbSource
			// 
			this.rtbSource.Location = new System.Drawing.Point(12, 39);
			this.rtbSource.Name = "rtbSource";
			this.rtbSource.Size = new System.Drawing.Size(776, 154);
			this.rtbSource.TabIndex = 2;
			this.rtbSource.Text = "";
			// 
			// btGetDetail
			// 
			this.btGetDetail.Location = new System.Drawing.Point(12, 199);
			this.btGetDetail.Name = "btGetDetail";
			this.btGetDetail.Size = new System.Drawing.Size(75, 31);
			this.btGetDetail.TabIndex = 1;
			this.btGetDetail.Text = "Get Detail";
			this.btGetDetail.UseVisualStyleBackColor = true;
			this.btGetDetail.Click += new System.EventHandler(this.btGetDetail_Click);
			// 
			// rtbDetail
			// 
			this.rtbDetail.Location = new System.Drawing.Point(12, 236);
			this.rtbDetail.Name = "rtbDetail";
			this.rtbDetail.Size = new System.Drawing.Size(776, 182);
			this.rtbDetail.TabIndex = 2;
			this.rtbDetail.Text = "";
			// 
			// WebTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 430);
			this.Controls.Add(this.rtbDetail);
			this.Controls.Add(this.btGetDetail);
			this.Controls.Add(this.rtbSource);
			this.Controls.Add(this.btGet);
			this.Name = "WebTest";
			this.Text = "WebTest";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btGet;
		private System.Windows.Forms.RichTextBox rtbSource;
		private System.Windows.Forms.Button btGetDetail;
		private System.Windows.Forms.RichTextBox rtbDetail;
	}
}