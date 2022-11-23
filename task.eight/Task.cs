using System;
namespace task.eight
{
	public class Task
	{
		private string _description;
		private DateTime _deadline;
		private Person _reporter;
		private Person? _assignee;
		private string _status;
		private Report _report;

        /// <summary>
        /// 
        /// </summary>
		public string description
		{
			set { _description = value; }
			get { return _description; }
		}
        public DateTime deadline
        {
            set { _deadline = value; }
            get { return _deadline; }
        }
        public Person reporter
        {
            set { _reporter = value; }
            get { return _reporter; }
        }
        public Person? assignee
        {
            set { _assignee = value; }
            get { return _assignee; }
        }
        public string status
        {
            set { _status = value; }
            get { return _status; }
        }
        public Report report
        {
            set { _report = value; }
            get { return _report; }
        }

        public Task(string description, DateTime deadline, Person reporter, Person? assignee, string status, Report report)
        {
            this.description = description;
            this.deadline = deadline;
            this.reporter = reporter;
            this.assignee = assignee;
            this.status = status;
            this.report = report;
        }
    }
}

