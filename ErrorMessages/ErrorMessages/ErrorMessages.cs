namespace ErrorMessages.ErrorMessages
{
    using NUnit.Framework;

    public static class ErrorMessages
    {
        private static string errorMessage = string.Empty;

        public static void AddErrorMessage(string error)
        {
            errorMessage = error;
        }

        public static void VerifyAndClearMessages()
        {
            var message = errorMessage;
            errorMessage = string.Empty;
            if (!string.IsNullOrEmpty(message))
            {
                Assert.Fail(message);
            }
        }
    }
}