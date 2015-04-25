using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExperianDemo;

namespace ExperianTests
{
    [TestClass]
    public class DragTestScript
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Telerik_Drag_Test()
        {
            DragDropPage.GoTo();
            DragDropPage.DragBlueCircleToPurpleCircle();

            Assert.IsTrue(DragDropPage.ValidateResult(), "Validation failed, text is incorrect.");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
