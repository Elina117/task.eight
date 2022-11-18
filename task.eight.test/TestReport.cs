using System;


namespace task.eight.test;


[TestClass]
public class TestReport
{
    [TestMethod]
    public void TestMethod1()
    {
        string text = "lknvoenv";
        DateTime date = new DateTime();
        Person assignee = new Person("fojeofj");
        string status = "fkvnoenv";

        Report classObject = new Report(text, date, assignee, status);

        Assert.AreEqual(text, classObject.text);
        Assert.AreEqual(date, classObject.date);
        Assert.AreEqual(assignee, classObject.assignee);
        Assert.AreEqual(status, classObject.status);

    }
}

