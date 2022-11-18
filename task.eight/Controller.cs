using System;
using System.Net.NetworkInformation;
using static System.Net.Mime.MediaTypeNames;

namespace task.eight
{
	public class Controller
	{
		
		public static Project CreateProject(string description, DateTime deadline, Person reporter, Person teamlead, List<Task> tasks)
        {
			string status = "ПРОЕКТ";
			Project project = new Project(description, deadline, reporter, teamlead, tasks, status);
			return project;
		}
		
		public static Task AssignPerformer(string description, DateTime deadline, Person reporter, Person assignee, Report report)
		{
			string status = "НАЗНАЧЕНА";
			Task task = new Task(description, deadline, reporter, assignee, status, report);
            return task;
        }

		public static Report CreateReport(string text, DateTime date, Person assignee)
		{
			Report report = new Report(text, date, assignee);
			return report;
		}

    }
}

