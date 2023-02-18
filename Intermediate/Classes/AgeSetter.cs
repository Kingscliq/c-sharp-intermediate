using System;
namespace Intermediate.Classes
{
	public class Person
	{
		//private DateTime _birthDate;

		//public AgeSetter(DateTime birthDate)
		//{
		//	this._birthDate = birthDate; 
		//}

		public DateTime BirthDate { get; set; }

		public int Age
		{
			get{
				var timeSpan = DateTime.Today - BirthDate;
				var years = timeSpan.Days / 355;
				return years;
			}
		}

	}
}

