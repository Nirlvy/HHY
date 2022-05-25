using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHY
{
    public class common
    {
        public static HHY.login login = null;


        public static login getLoginForm()
        {
            if (login == null)
            {
                login = new HHY.login();
            }
            return login;
        }



    }
}
