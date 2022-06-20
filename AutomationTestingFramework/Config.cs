namespace AutomationTestingFramework
{
    public static class Config
    {
        public static string BaseURL = "https://testing.todorvachev.com/";

        public static class Credentials
        {
            public static class Valid
            {
                public static string UserName = "ValidUser";
                public static string Password = "12qw!pQW";
                public static string RepeatPassword = "12qw!pQW";
                public static string Email = "example@example.com";
            }

            public static class Invalid
            {
                public static class UserName
                {
                    public static string FourCharacters = "qwer";
                    public static string ThirteenCharacters = "qwerHJHjhkjhk";
                }
                public static class Password
                {

                }
                public static class Email
                {

                }
            }
        }

        public static class AlertMessages
        {
            public static string SuccessfulLogin = "Succesful login!";
        }
    }
}
