namespace CaptureScreenshot.Screenshot
{
    using System;
    using System.IO;

    using Logger.Logger;

    using OpenQA.Selenium;

    using Selenium.Driver;

    using TestContexts.TestContexts;

    public static class Screenshot
    {
        public static void Capture(string testName)
        {
            if (Directory.Exists(TestContexts.GetArtifactsPath()))
            {
                if (string.IsNullOrEmpty(testName))
                {
                    // temporary way to investigate tests that fails in setup section
                    testName = Guid.NewGuid().ToString();
                }

                var date = DateTime.Now;
                var formattedDate = $"{date.Year}-{date.Month}-{date.Day}  {date.Hour}_{date.Minute} ";
                var screenshotFileName = TestContexts.GetArtifactsPath() + "\\" + formattedDate + testName + ".jpg";
                Logger.Log("Attempting to take a screenshot.");
                try
                {
                    var ss = ((ITakesScreenshot)Driver.Instance).GetScreenshot();
                    ss.SaveAsFile(screenshotFileName, ScreenshotImageFormat.Jpeg);
                    Logger.Log($"Screenshot saved to {screenshotFileName}");
                }
                catch (Exception e)
                {
                    Logger.Log("Error when I tried to take a screenshot.");
                    Logger.Log(e.Message);
                    throw;
                }
            }
            else
            {
                Logger.Log($@"Missing Folder {TestContexts.GetArtifactsPath()}");
            }
        }
    }
}