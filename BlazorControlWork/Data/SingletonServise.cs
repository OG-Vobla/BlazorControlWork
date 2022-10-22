
using System.Collections.Generic;

namespace BlazorControlWork.Data
{
    public class SingletonServise
    {
        User user;

        public User GetUser()
        {

            return user;
        }
        public void SetUser(User newUser)
        {
            user = newUser;
        }
    }

}
