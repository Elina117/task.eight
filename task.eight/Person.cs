using System;
namespace task.eight
{
	public class Person
	{
		private string _name;

		public string name
		{
			set { _name = value; }
			get { return _name; }
		}

		public Person(string name)
		{
			this.name = name;
		}
	}
}

