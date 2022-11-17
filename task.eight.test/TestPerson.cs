using System;


namespace task.eight.test;

[TestClass]
public class TestPerson
{
    [TestMethod]
    public void TestMethod1()
    {
        string name = "Dina";

        Person classObject = new Person(name);

        Assert.AreEqual(name, classObject.name);

    }
}
