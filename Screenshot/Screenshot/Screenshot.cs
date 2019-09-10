using System;
using System.IO;
using OpenQA.Selenium;
using Selenium.Driver;
using static Logger.Logger.Logger;
using static TestContexts.TestContexts.TestContexts;

namespace Screenshot.Screenshot
{
    public static class Screenshot
    {
        public static void Capture(string testName)
        {
            if (Directory.Exists(GetArtifactsPath()))
            {
                if (string.IsNullOrEmpty(testName)) //temporary way to investigate tests that fails in setup section
                    testName = Guid.NewGuid().ToString();


                var date = DateTime.Now;
                var formattedDate = $"{date.Year}-{date.Month}-{date.Day}  {date.Hour}_{date.Minute} ";
                var screenshotFileName = GetArtifactsPath() + "\\" + formattedDate + testName + ".jpg";
                Log("Attempting to take a screenshot.");
                try
                {
                    var ss = ((ITakesScreenshot) Driver.Instance).GetScreenshot();
                    ss.SaveAsFile(screenshotFileName, ScreenshotImageFormat.Jpeg);
                    Log($"Screenshot saved to {screenshotFileName}");
                }
                catch (Exception e)
                {
                    Log("Error when I tried to take a screenshot.");
                    Log(e.Message);
                    throw;
                }
            }
            else
            {
                Log($@"Missing Folder {GetArtifactsPath()}");
            }
        }
    }
}