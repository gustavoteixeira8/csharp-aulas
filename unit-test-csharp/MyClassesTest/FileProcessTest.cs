using MyClasses;

namespace MyClassesTest;

[TestClass]
public class FileProcessTest
{
    private FileProcess fp = new FileProcess();
    private const string BAD_FILENAME = "/SomeFile";
    private string GOOD_FILENAME = "[AppPath]/Test.js";
    private const string FILENAME_DEPLOY = "Test.js";
    public TestContext TestContext { get; set; }

    #region 

    // Roda no inicio de todos os testes
    // [TestInitialize]
    // public void TestInitialize()
    // {
    //     if (TestContext.TestName == "FilenameDoesExists") 
    //     {
    //         SetGoodFilename();

    //         TestContext.WriteLine("Creating file");

    //         File.AppendAllText(GOOD_FILENAME, "Some text");

    //         TestContext.WriteLine("Testing file");
    //     }
    // }

    // // Roda no final de todos os testes
    // [TestCleanup]
    // public void TestCleanup() 
    // {
    //     if (TestContext.TestName == "FilenameDoesExists") 
    //     {
    //         TestContext.WriteLine("Deleting file");
    //         File.Delete(GOOD_FILENAME);
    //     }
    // }

    #endregion

    public void SetGoodFilename()
    {
        // GOOD_FILENAME = System.Configuration.ConfigurationManager.AppSettings["GOOD_FILENAME"];

        if (GOOD_FILENAME.Contains("[AppPath]"))
        {
            GOOD_FILENAME = GOOD_FILENAME.Replace("[AppPath]", Directory.GetCurrentDirectory());
        }

        TestContext.WriteLine($"Setup GOOD_FILENAME: {GOOD_FILENAME}");
    }

    [TestMethod]
    [Description("Check to see if a file exists")]
    [Priority(0)]
    [TestCategory("NoException")]
    [DeploymentItem(FILENAME_DEPLOY)]
    public void FilenameDoesExists()
    { 
        // SetGoodFilename();

        string filename = $"{TestContext.DeploymentDirectory}/{FILENAME_DEPLOY}";

        TestContext.WriteLine("Creating file");

        File.AppendAllText(filename, "Some text");

        TestContext.WriteLine("Testing file");

        bool fpResponse = fp.FileExists(filename);

        TestContext.WriteLine("Deleting file");
        File.Delete(filename);

        Assert.IsTrue(fpResponse);
    }

    [TestMethod]
    [Description("Check to see if a file not exists")]
    [Owner("Gustavo")]
    [Ignore]
    public void FilenameDoesNotExists()
    {
        TestContext.WriteLine("Testing bad filename");

        bool fpResponse = fp.FileExists(BAD_FILENAME);

        Assert.IsFalse(fpResponse);
    }


    [TestMethod]
    [Priority(1)]
    // [ExpectedException(typeof(ArgumentNullException))]
    public void FilenameEmptyThrowsArgumentNullException()
    {
        try
        {
            fp.FileExists("");
            // fp.FileExists(null);
        }
        catch (ArgumentNullException)
        {
            // If fp.FileExists throw an error, we catch the error, return void and test is passed
            return;
        }

        Assert.Fail("fail expected");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    [Timeout(3100)]
    [Priority(0)]
    public void FilenameNullThrowsArgumentNullException() 
    {
        System.Threading.Thread.Sleep(3000);
        fp.FileExists(null);
    }

}