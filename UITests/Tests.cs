using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using FormsTest.Extension;

namespace FormsTestSample.UITests
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin Forms!"));
            app.Screenshot("Welcome screen.");

            Assert.IsTrue(results.Any());
        }
        [Test]
        public void TestFormsLabelTextColorProperty()
        {
            app.WaitForElement("FtLabel");
            string isVisible = app.FormsPropertyGet("FtLabel.IsVisible");
            string x = app.FormsPropertyGet("FtLabel.X");
                     
        }
    }
}
