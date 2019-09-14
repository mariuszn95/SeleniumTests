namespace ErrorMessages.ErrorMessages
{
    using Logger.Logger;

    using NUnit.Framework;

    public static class ErrorMessages
    {
        private static string errorMessage = string.Empty;

        public static void AddErrorMessage(string error)
        {
            errorMessage = error;
            LoggerError.Log("Add ----- " + error);
        }

        public static void VerifyAndClearMessages()
        {
            var message = errorMessage;
            errorMessage = string.Empty;
            if (!string.IsNullOrEmpty(message))
            {
                LoggerError.Log("Verify ----- " + message);
                Assert.Fail(message);
            }
        }
    }
}