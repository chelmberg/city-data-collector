using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDataCollector
{
	class City
	{
		string cityname;
		List<CityData> populationData;

		public City (string _cityname)
		{
			Cityname = _cityname;
			populationData = new List<CityData>();
		}
		public string Cityname
		{
			get { return cityname; }
			set
			{
				if (value.Length>0)
				{
					cityname = value;
				}
				else
				{
					throw new ApplicationException("Name darf nicht leer sein!");
				}
			}
		}
		public int DataCount
		{
			get	{ return populationData.Count; }
		}
		public int Population
		{
			get { return populationData[populationData.Count - 1].Population; }
		}
		public bool AddCityData(CityData cd)
		{
			bool eingefuegt = false;
			bool vorhanden = false;
			foreach (CityData data in populationData)
			{
				if (data.Year==cd.Year)
				{
					vorhanden = true;
				}
			}
			if (vorhanden==false)
			{
				int ctr=0;
				foreach (CityData data in populationData)
				{
					if (data.Year<cd.Year)
					{
						ctr++;
					}
				}
				populationData.Insert(ctr, cd);
				eingefuegt = true;
			}
			return eingefuegt;
		}
	}
}
