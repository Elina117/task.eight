using System;
using System.Net.NetworkInformation;

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
		

	}
}

