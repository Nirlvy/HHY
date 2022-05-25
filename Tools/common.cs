namespace HHY
{
    public class common
    {
        public static login login = null;
        public static user1 user1 = null;

        public static login getLoginForm()
        {
            if (login == null)
            {
                login = new login();
            }
            return login;
        }

        public static user1 getUser1Form()
        {
            if (user1 == null)
            {
                user1 = new user1();
            }
            return user1;
        }
    }
}
