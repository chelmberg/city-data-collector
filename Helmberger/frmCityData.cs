using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CityDataCollector
{
	public partial class frmCityData : Form
	{
        #region Deklarations
        City[] citylist=new City[100];
		int aktLen=0;
		int einzufuegendeStelle;

        #endregion

        #region Constructor
        public frmCityData()
		{
			InitializeComponent();
		}

        #endregion

        #region Methods
		/// <summary>
		/// Adds new city details to the list
		/// </summary>
        private void AddData()
        {
			bool vorhanden = false;
			for (int i = 0; i < aktLen; i++)
			{
				if (citylist[i].Cityname == txtCityname.Text.ToString())
				{
					vorhanden = true;
					einzufuegendeStelle = i;
				}
			}
			if (vorhanden == false)
			{
				City c = new City(txtCityname.Text.ToString());
				bool eingefuegt;

				CityData cd = new CityData(Convert.ToInt32(txtYear.Text), Convert.ToInt32(txtFemale.Text), Convert.ToInt32(txtMale.Text));
				eingefuegt = c.AddCityData(cd);
				citylist[aktLen] = c;
				aktLen++;

				lbData.Items.Clear();
				for (int i = 0; i < aktLen; i++)
				{
					lbData.Items.Add(i + 1 + "-" + citylist[i].Cityname + ": " + citylist[i].DataCount + " Einträge, " + citylist[i].Population + " Bewohner");
				}
			}
			else
			{
				CityData cd = new CityData(Convert.ToInt32(txtYear.Text), Convert.ToInt32(txtFemale.Text), Convert.ToInt32(txtMale.Text));
				bool eingefuegt;

				lbData.Items.Clear();
				eingefuegt = citylist[einzufuegendeStelle].AddCityData(cd);
				for (int i = 0; i < aktLen; i++)
				{
					lbData.Items.Add(i + 1 + "-" + citylist[i].Cityname + ": " + citylist[i].DataCount + " Einträge, " + citylist[i].Population + " Bewohner");
				}
			}
		}

		/// <summary>
		/// Imports city details form an external file
		/// </summary>
		private void LoadData()
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "cbt Datei auswaehlen";
			ofd.Filter = "cbt Datei|*.cbt";
			ofd.ShowDialog();
			if (ofd.FileName.Length > 0)
			{
				StreamReader sr = new StreamReader(ofd.FileName);
				string zeilen = "";
				string newCity;
				City newC = null;
				while (sr.Peek() >= 0)
				{
					zeilen = sr.ReadLine();
					if (zeilen.StartsWith("<"))
					{
						zeilen = zeilen.Remove(0, 1);
						zeilen = zeilen.Remove(zeilen.Length - 1, 1);
						Console.WriteLine(zeilen);
						newCity = zeilen;
						newC = new City(newCity);
						citylist[aktLen] = newC;
						aktLen++;
					}
					else
					{
						try
						{
							string[] daten = new string[3];
							daten = zeilen.Split(';');

							int jahr = Convert.ToInt32(daten[0]);
							int male = Convert.ToInt32(daten[1]);
							int female = Convert.ToInt32(daten[2]);

							Console.WriteLine(jahr);
							Console.WriteLine(male);
							Console.WriteLine(female);

							CityData newData = new CityData(jahr, female, male);
							newC.AddCityData(newData);
						}
						catch (FormatException fex)
						{
							MessageBox.Show(fex.Message, "Format Expection", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						catch (ApplicationException aex)
						{
							MessageBox.Show(aex.Message, "Application Expection", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "Expection", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				sr.Close();
				lbData.Items.Clear();
				for (int i = 0; i < aktLen; i++)
				{
					lbData.Items.Add(i + 1 + "-" + citylist[i].Cityname + ": " + citylist[i].DataCount + " Einträge, " + citylist[i].Population + " Bewohner");
				}
			}
		}

        #endregion

        #region Events
        private void btnAddData_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			AddData();
			Cursor = Cursors.Default;
		}

		private void btnLoadData_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			LoadData();
			Cursor = Cursors.Default;
		}

        #endregion
    }
}
