using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExperianDemo;

namespace ExperianTests
{
    [TestClass]
    public class UploadTestScript
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Telerik_Upload_Test()
        {
            UploadPage.GoTo();
            UploadPage.ClickSelectFilesButton();
            UploadPage.Upload("C:\\Text2.txt");

            Assert.IsTrue(UploadPage.ValidateResult(), "Validation failed, Upload did not complete.");
            
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
