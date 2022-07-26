namespace MyClassesTest;

[TestClass]
public class TestingValuesTest {
    [TestMethod]
    [Description("test if strings are equal")]
    public void AreEqual() {
        string nameA = "Gustavo";
        string nameB = "Gustavo";

        Assert.AreEqual(nameA, nameB);
        // Assert.AreNotEqual(nameA, nameB);
    }

    [TestMethod]
    public void AreNotEqual() {
        int num1 = 51;
        float num2 = 50.0f;

        // Assert.AreEqual(num1, num2);
        Assert.AreNotEqual(num1, num2);
    }

    [TestMethod]
    [ExpectedException(typeof(AssertFailedException))]
    public void AreEqualTestSensitive() {
        string name1 = "Ana";
        string name2 = "ana";

        Assert.AreEqual(name1, name2, false);
    }


    [TestMethod]
    public void AreSame() {
        User user1 = new User("Gustavo");
        User user2 = user1;
        // new User("Ana")

        Assert.AreSame(user1, user2);
    }

    [TestMethod]
    public void AreNotSame() {
        User user1 = new User("Gustavo");
        User user2 = new User("Ana");

        Assert.AreNotSame(user1, user2);
    }

    [TestMethod]
    public void IsInstanceOf() {
        // User user1 = new User("Gustavo");
        Student user1 = new Student("Gustavo");

        Assert.IsInstanceOfType(user1, typeof(User));
    }

    [TestMethod]
    // [ExpectedException(typeof(AssertFailedException))]
    public void IsNotInstanceOf() {
        Student user2 = new Student("Ana");
        
        Assert.IsNotInstanceOfType(user2, typeof(Car));
    }

    [TestMethod]
    public void IsNull() {
        Student s1 = new Student("Gustavo");

        s1 = null;

        Assert.IsNull(s1);
    }

    [TestMethod]
    public void IsNotNull() {
        Car car1 = new Car(2005);

        Assert.IsNotNull(car1);
    }
}