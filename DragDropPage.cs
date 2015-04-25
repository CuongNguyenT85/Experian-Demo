using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace ExperianDemo
{
    public class DragDropPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("http://demos.telerik.com/kendo-ui/dragdrop/index");
        }

        public static void DragBlueCircleToPurpleCircle()
        {
            var BlueCircle = Driver.Instance.FindElement(By.Id("draggable"));
            var PurpleCircle = Driver.Instance.FindElement(By.Id("droptarget"));

            Actions builder = new Actions(Driver.Instance);

            IAction dragAndDrop = builder.ClickAndHold(BlueCircle).MoveToElement(PurpleCircle).Release().Build();

            dragAndDrop.Perform();

        }

        public static bool ValidateResult()
        {
            var ResultString = Driver.Instance.FindElement(By.Id("droptarget")).Text;

            if (ResultString == "You did great!")
                return true;
            return false;
        }
    }
}
