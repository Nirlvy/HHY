namespace HHY
{
    public class common
    {
        public static login login = null;
        public static user1 user1 = null;
        public static borrow borrow = null;
        public static giveback giveback = null;
        public static admin admin = null;
        public static list list = null;
        public static sign_up sign_up = null;

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

        public static admin getAdminForm()
        {
            if (admin == null)
            {
                admin = new admin();
            }
            return admin;
        }

        public static list getListForm()
        {
            if (list == null)
            {
                list = new list();
            }
            return list;
        }

        public static sign_up getSign_upForm()
        {
            if (sign_up == null)
            {
                sign_up = new sign_up();
            }
            return sign_up;
        }
    }
}
