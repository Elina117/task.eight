using System;


namespace task.eight.test;

[TestClass]
public class TestController
{
    [TestMethod]
    public void TestMethod1()
    {
        string description = "leknvl";
        DateTime deadline = new DateTime();
        Person reporter = new Person("lvnle");
        Person teamlead = new Person("kjbv");
        Task task1 = new Task("lkvne", new DateTime(), new Person("vjb"), new Person("elvpj"), "lcnlv", new Report("lwcbc", new DateTime(), new Person("wlc"), "gjoe"));
        Task task2 = new Task("lfkev", new DateTime(), new Person("kfn"), new Person("ve"), "etg", new Report("vfe", new DateTime(), new Person("vefve"), "iegh"));
        Task task3 = new Task("rbbbt", new DateTime(), new Person("greerg"), new Person("gtb"), "bt", new Report("vcer", new DateTime(), new Person("brgb"), "hog"));
        List<Task> tasks = new List<Task>() { task1, task2, task3 };
        

        Project project = Controller.CreateProject(description, deadline, reporter, teamlead, tasks);

        Assert.AreEqual(description, project.description);
        Assert.AreEqual(deadline, project.deadline);
        Assert.AreEqual(reporter, project.reporter);
        Assert.AreEqual(teamlead, project.teamlead);
        Assert.AreEqual(tasks, project.tasks);
        Assert.AreEqual("ПРОЕКТ", project.status); 

    }
    

}

