using System;


namespace task.eight
{
	public class Program
	{
        static void Main(string[] args)
        {
            
            //1 method
            string description = "Website";
            DateTime deadline = new DateTime();
            Person reporter = new Person("Ahmetov");
            Person teamlead = new Person("Khuzina");
            List<Task> tasks = new List<Task>() { };
  
            Project project = Controller.CreateProject(description, deadline, reporter, teamlead, tasks);
            Console.WriteLine(project);


            //2 method
            Task task1 = new Task("lkvne", new DateTime(), new Person("vjb"), new Person("elvpj"), "lcnlv", new Report("lwcbc", new DateTime(), new Person("wlc"), "fkkke"));
            Task task2 = new Task("lfkev", new DateTime(), new Person("kfn"), new Person("ve"), "etg", new Report("vfe", new DateTime(), new Person("vefve"), "ckkf"));
            Task task3 = new Task("rbbbt", new DateTime(), new Person("greerg"), new Person("gtb"), "bt", new Report("vcer", new DateTime(), new Person("brgb"), "kfkf"));
            Task task4 = new Task("lfkev", new DateTime(), new Person("kfn"), new Person("ve"), "etg", new Report("vfe", new DateTime(), new Person("vefve"), "kvkf"));
            Task task5 = new Task("lfkev", new DateTime(), new Person("kfn"), new Person("ve"), "etg", new Report("vfe", new DateTime(), new Person("vefve"), "kvk"));
            Task task6 = new Task("lfkev", new DateTime(), new Person("kfn"), new Person("ve"), "etg", new Report("vfe", new DateTime(), new Person("vefve"), "rfoj"));
            Task task7 = new Task("lfkev", new DateTime(), new Person("kfn"), new Person("ve"), "etg", new Report("vfe", new DateTime(), new Person("vefve"), "go4t"));
            Task task8 = new Task("lfkev", new DateTime(), new Person("kfn"), new Person("ve"), "etg", new Report("vfe", new DateTime(), new Person("vefve"), "jog"));
            Task task9 = new Task("lfkev", new DateTime(), new Person("kfn"), new Person("ve"), "etg", new Report("vfe", new DateTime(), new Person("vefve"), "tg4ho"));
            Task task10 = new Task("lfkev", new DateTime(), new Person("kfn"), new Person("ve"), "etg", new Report("vfe", new DateTime(), new Person("vefve"), "gjit"));

            project.tasks.Add(task1);
            project.tasks.Add(task2);
            project.tasks.Add(task3);
            project.tasks.Add(task4);
            project.tasks.Add(task5);
            project.tasks.Add(task6);
            project.tasks.Add(task7);
            project.tasks.Add(task8);
            project.tasks.Add(task9);
            project.tasks.Add(task10);

            Console.WriteLine(project);


            //3 method
            string description = "oooo";
            DateTime deadline = new DateTime();
            Person reporter = new Person("tgho");
            Person assignee = new Person("pgje");
            string status = "jfjj";
            Report report = new Report("ieohg", new DateTime(), new Person("ggro"));

            Task task = Controller.AssignPerformer(description, deadline, reporter, assignee, report);

            //4 method
            string text = "lknvoenv";
            DateTime date = new DateTime();
            Person assignee = new Person("fojeofj");

            Report report = Controller.CreateReport(text, date, assignee);

        }

    }
}

