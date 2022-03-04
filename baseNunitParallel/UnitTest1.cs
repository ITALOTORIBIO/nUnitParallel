using NUnit.Framework;
using baseNunitParallel.Factory;
using OpenQA.Selenium;
using NUnit.Allure.Core;
using Allure.Commons;
using NUnit.Allure.Attributes;

namespace baseNunitParallel;

[TestFixture]
[AllureNUnit]
public class Tests
{
    private IWebDriver driver;
    DriverFactory driverFactory;
    string hubUrl;

    [SetUp]
    public void Setup()
    {
        AllureLifecycle.Instance.CleanupResultDirectory();
        driverFactory = new DriverFactory();
        //driverFactory.getDriverBrowser(config_properties.browser);
        //driver = driverFactory.getDriver();

    }

    [TearDown]
    protected void TearDown()
    {
       
    }

    [Test]
    [Parallelizable]
    [Category("SampleTag")]
    [Description("Test1")]
    [AllureTag("NUnit", "Debug")]
    [AllureSeverity(SeverityLevel.critical)]
    [AllureFeature("Core")]
    public void OpenGoogleAndSearch()
    {
        driver.Navigate().GoToUrl("https://www.google.com");
        driver.Manage().Window.Maximize();
        driver.FindElement(By.Name("q")).SendKeys("I Want to se this on a remote machine");
    }

    [Test]
    [Parallelizable]
    [Category("SampleTag")]
    [Description("Test2")]
    [AllureTag("NUnit", "Debug")]
    [AllureSeverity(SeverityLevel.critical)]
    [AllureFeature("Core")]
    public void OpenBingAndSearch()
    {
        driver.Navigate().GoToUrl("https://www.bing.com/");
        driver.Manage().Window.Maximize();
        driver.FindElement(By.Name("q")).SendKeys("I Want to seee this on a remote machine");
    }


}
