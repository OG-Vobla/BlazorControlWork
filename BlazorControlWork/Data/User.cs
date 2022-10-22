using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Xml.Linq;

namespace BlazorControlWork.Data
{
    public class User
    {
        public User(string lName, string fName, string login, string password, string email)
        {
            LName = lName;
            FName = fName;
            Login = login;
            Password = password;
            Email = email;
        }
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        public string LName { get; set; }
        public string FName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }    
        public string Email { get; set; }


    }
}
