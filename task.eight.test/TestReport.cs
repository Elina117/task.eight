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

        Report classObject = new Report(text, date, assignee);

        Assert.AreEqual(text, classObject.text);
        Assert.AreEqual(date, classObject.date);
        Assert.AreEqual(assignee, classObject.assignee);

    }
}

