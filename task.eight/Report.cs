using System;
namespace task.eight
{
	public class Report
	{
		private string _text;
		private DateTime _date;
		private Person _assignee;
		private string _status;

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
		public string status
		{
			set { _status = value; }
			get { return _status; }
		}

		public Report(string text, DateTime date, Person assignee, string status)
		{
			this.text = text;
			this.date = date;
			this.assignee = assignee;
			this.status = status;

		}
    }
}

