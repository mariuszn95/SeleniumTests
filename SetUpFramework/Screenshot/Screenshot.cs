using System;
using static Screenshot.Screenshot.Screenshot;
using static TestContexts.TestContexts.TestContexts;
using static ErrorMessages.ErrorMessages.ErrorMessages;

namespace SetUpFramework.Screenshot
{
    public static class Screenshot
    {
        public static void CaptureScreenshot(string testName)
        {
            try
            {
                if (GetArtifactsPath() != null) Capture(testName);
            }
            catch (Exception e)
            {
                AddErrorMessage(e.StackTrace);
            }
        }
    }
}