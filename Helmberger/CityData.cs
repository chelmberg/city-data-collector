using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDataCollector
{
	class CityData
	{
		int year, popFemale, popMale;

		public CityData (int _year,int _popFemale,int _popMale)
		{
			Year = _year;
			PopFemale = _popFemale;
			PopMale = _popMale;
		}

		public int Year
		{
			get { return year; }
			set
			{
				if (value>=1800 && value <= DateTime.Now.Year)
				{
					year = value;
				}
				else
				{
					throw new ApplicationException("Der Wert muss zwischen 1800 und 2014 liegen.");
				}
			}
		}
		public int PopFemale
		{
			get { return popFemale; }
			set
			{
				if (value>=0)
				{
					popFemale = value;
				}
				else
				{
					throw new ApplicationException("Wert darf nicht negativ sein!");
				}
			}
		}
		public int PopMale
		{
			get { return popMale; }
			set
			{
				if (value >= 0)
				{
					popMale = value;
				}
				else
				{
					throw new ApplicationException("Wert darf nicht negativ sein!");
				}
			}
		}
		public int Population
		{
			get { return popFemale + popMale; }
		}
	}
}
