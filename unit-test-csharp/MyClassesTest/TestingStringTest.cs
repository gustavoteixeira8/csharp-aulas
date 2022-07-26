namespace MyClassesTest;

[TestClass]
public class TestingStringTest {
    [TestMethod]
    public void TestContains() {
        string name = "Gustavo Teixeira";
        string name2 = "Teixeira";

        StringAssert.Contains(name, name2);
    }

    [TestMethod]
    public void TestStartsWith() {
        string str = "Olá mundo";
        string str2 = "Olá";

        StringAssert.StartsWith(str, str2);
    }

    [TestMethod]
    public void TestEndsWith() {
        string str = "Olá mundo";
        string str2 = "mundo";

        StringAssert.EndsWith(str, str2);
    }
}