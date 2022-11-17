using System;
namespace task.eight
{
	public class Report
	{
		private string _text;
		private DateTime _date;
		private Person _assignee;

		public string text
		{
			set { _text = value; }
			get { return _text; }
		}
        public DateTime date
        {
            set { _date = value; }
            get { return _date; }
        }
		public Person assignee
        {
			set { _assignee = value; }
			get { return _assignee; }
		}

		public Report(string text, DateTime date, Person assignee)
		{
			this.text = text;
			this.date = date;
			this.assignee = assignee;

		}
    }
}

