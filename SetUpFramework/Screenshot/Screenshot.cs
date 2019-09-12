namespace SetUpFramework.Screenshot
{
    using System;

    using ErrorMessages.ErrorMessages;

    using TestContexts.TestContexts;

    public static class Screenshot
    {
        public static void CaptureScreenshot(string testName)
        {
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
        }
    }
}