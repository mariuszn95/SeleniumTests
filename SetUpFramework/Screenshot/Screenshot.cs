namespace SetUpFramework.Screenshot
{
    using System;
    using System.Reflection;

    using ErrorMessages.ErrorMessages;

    using Logger.Logger;

    using TestContexts.TestContexts;

    public static class Screenshot
    {
        public static void CaptureScreenshot(string testName)
        {
            LoggerPage.LogStart(MethodBase.GetCurrentMethod().Name);

            try
            {
                if (TestContexts.GetArtifactsPath() != null)
                {
                    global::CaptureScreenshot.Screenshot.Screenshot.Capture(testName);
                }
            }
            catch (Exception e)
            {
                ErrorMessages.AddErrorMessage(e.StackTrace);
            }

            LoggerPage.LogEnd(MethodBase.GetCurrentMethod().Name);
        }
    }
}