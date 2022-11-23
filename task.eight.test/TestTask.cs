using System;


namespace task.eight.test;

[TestClass]
public class TestTask
{
    [TestMethod]
    public void TestMethod1()
    {
        string description = "oooo";
        DateTime deadline = new DateTime();
        Person reporter = new Person("tgho");
        Person assignee = new Person("pgje");
        string status = "jfjj";
        Report report = new Report("ieohg", new DateTime(), new Person("ggro"), "hgri");

        Task classObject = new Task(description, deadline, reporter, assignee, status, report);

        Assert.AreEqual(description, classObject.description);
        Assert.AreEqual(deadline, classObject.deadline);
        Assert.AreEqual(reporter, classObject.reporter);
        Assert.AreEqual(assignee, classObject.assignee);
        Assert.AreEqual(status, classObject.status);
        Assert.AreEqual(report, classObject.report);

    }
    [TestMethod]
    public void TestMethod2()
    {
        string description = "oooo";
        DateTime deadline = new DateTime();
        Person reporter = new Person("tgho");
        Person? assignee = null;
        string status = "jfjj";
        Report report = new Report("ieohg", new DateTime(), new Person("ggro"), "jgirgj");

        Task classObject = new Task(description, deadline, reporter, assignee, status, report);

        Assert.AreEqual(description, classObject.description);
        Assert.AreEqual(deadline, classObject.deadline);
        Assert.AreEqual(reporter, classObject.reporter);
        Assert.AreEqual(assignee, classObject.assignee);
        Assert.AreEqual(status, classObject.status);
        Assert.AreEqual(report, classObject.report);

    }
}