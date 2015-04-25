using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace ExperianDemo
{
    public class UploadPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("http://demos.telerik.com/kendo-ui/upload/initialfiles");
        }

        public static void ClickSelectFilesButton()
        {
            Driver.Instance.FindElement(By.Id("files")).Click();
        }

        public static void Upload(string fileName)
        {
            SendKeys.SendWait(fileName);
            Thread.Sleep(3000);
            SendKeys.SendWait("{Enter}");
        }

        public static bool ValidateResult()
        {
            var done = Driver.Instance.FindElement(By.CssSelector("strong[class='k-upload-status k-upload-status-total']")).Text;
            var percent = Driver.Instance.FindElement(By.ClassName("k-upload-pct")).Text;
            if (done=="Doneuploaded" && percent=="100%")
                return true;
            return false;
        }
    }
}
