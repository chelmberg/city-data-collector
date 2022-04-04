namespace CityDataCollector
{
	partial class frmCityData
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            this.lbData = new System.Windows.Forms.ListBox();
            this.txtCityname = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtFemale = new System.Windows.Forms.TextBox();
            this.txtMale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddData = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbData
            // 
            this.lbData.FormattingEnabled = true;
            this.lbData.ItemHeight = 16;
            this.lbData.Location = new System.Drawing.Point(45, 37);
            this.lbData.Margin = new System.Windows.Forms.Padding(4);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(677, 500);
            this.lbData.TabIndex = 0;
            // 
            // txtCityname
            // 
            this.txtCityname.Location = new System.Drawing.Point(192, 29);
            this.txtCityname.Margin = new System.Windows.Forms.Padding(4);
            this.txtCityname.Name = "txtCityname";
            this.txtCityname.Size = new System.Drawing.Size(364, 22);
            this.txtCityname.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(192, 78);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(364, 22);
            this.txtYear.TabIndex = 2;
            // 
            // txtFemale
            // 
            this.txtFemale.Location = new System.Drawing.Point(192, 126);
            this.txtFemale.Margin = new System.Windows.Forms.Padding(4);
            this.txtFemale.Name = "txtFemale";
            this.txtFemale.Size = new System.Drawing.Size(364, 22);
            this.txtFemale.TabIndex = 3;
            // 
            // txtMale
            // 
            this.txtMale.Location = new System.Drawing.Point(192, 178);
            this.txtMale.Margin = new System.Windows.Forms.Padding(4);
            this.txtMale.Name = "txtMale";
            this.txtMale.Size = new System.Drawing.Size(364, 22);
            this.txtMale.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "cityname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "population female:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "population male:";
            // 
            // btnAddData
            // 
            this.btnAddData.Location = new System.Drawing.Point(38, 236);
            this.btnAddData.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(169, 48);
            this.btnAddData.TabIndex = 9;
            this.btnAddData.Text = "add population data";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(45, 545);
            this.btnLoadData.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(159, 47);
            this.btnLoadData.TabIndex = 10;
            this.btnLoadData.Text = "load data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddData);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMale);
            this.groupBox1.Controls.Add(this.txtFemale);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.txtCityname);
            this.groupBox1.Location = new System.Drawing.Point(818, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 312);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New city details";
            // 
            // frmCityData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 694);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.lbData);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCityData";
            this.Text = "City Data";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbData;
		private System.Windows.Forms.TextBox txtCityname;
		private System.Windows.Forms.TextBox txtYear;
		private System.Windows.Forms.TextBox txtFemale;
		private System.Windows.Forms.TextBox txtMale;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAddData;
		private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

