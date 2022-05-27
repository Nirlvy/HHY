namespace HHY
{
    public class common
    {
        public static login login = null;
        public static user1 user1 = null;
        public static borrow borrow = null;
        public static giveback giveback = null;

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

        public static borrow getBorrowForm()
        {
            if (borrow == null)
            {
                borrow = new borrow();
            }
            return borrow;
        }

        public static giveback getGivebackForm()
        {
            if (giveback == null)
            {
                giveback = new giveback();
            }
            return giveback;
        }
    }
}
