
using System.Collections.Generic;

namespace BlazorControlWork.Data
{
    public class SingletonServise
    {
        public static User user;

        public static User GetUser()
        {
            return user;
        }
        public static void SetUser(User newUser)
        {
            user = newUser;
        }
    }

}
