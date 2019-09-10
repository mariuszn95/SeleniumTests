using NUnit.Framework;

namespace ErrorMessages.ErrorMessages
{
    public static class ErrorMessages
    {
        private static string _errorMessage = string.Empty;

        public static void AddErrorMessage(string error)
        {
            _errorMessage = error;
        }

        public static void VerifyAndClearMessages()
        {
            var message = _errorMessage;
            _errorMessage = string.Empty;
            if (!string.IsNullOrEmpty(message))
                Assert.Fail(message);
        }
    }
}