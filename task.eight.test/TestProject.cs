using System;
using task.eight;

namespace task.eight.test;

[TestClass]
public class TestProject
{
    [TestMethod]
    public void TestMethod1()
    {
        string description = "leknvl";
        DateTime deadline = new DateTime();
        Person reporter = new Person("lvnle");
        Person teamlead = new Person("kjbv");
        Task task1 = new Task("lkvne", new DateTime(), new Person("vjb"), new Person("elvpj"), "lcnlv", new Report("lwcbc", new DateTime(), new Person("wlc")));
        Task task2 = new Task("lfkev", new DateTime(), new Person("kfn"), new Person("ve"), "etg", new Report("vfe", new DateTime(), new Person("vefve")));
        Task task3 = new Task("rbbbt", new DateTime(), new Person("greerg"), new Person("gtb"), "bt", new Report("vcer", new DateTime(), new Person("brgb")));
        List<Task> tasks = new List<Task>() { task1, task2, task3 };
        string status = "wocwpn";

        Project classObject = new Project(description, deadline, reporter, teamlead, tasks, status);

        Assert.AreEqual(description, classObject.description);
        Assert.AreEqual(deadline, classObject.deadline);
        Assert.AreEqual(reporter, classObject.reporter);
        Assert.AreEqual(teamlead, classObject.teamlead);
        Assert.AreEqual(tasks, classObject.tasks);
        Assert.AreEqual(status, classObject.status);


        //classObject.tasks[0].assignee = new Person("Elina");
    }
}

