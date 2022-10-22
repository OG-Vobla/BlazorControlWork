using System;
using MongoDB.Driver;

namespace BlazorControlWork.Data
{
    public class MongoDb
    {
        static MongoClient client;
        static IMongoDatabase UserDatabase;
        static IMongoCollection<User> UsersCollection;

        static MongoDb()
        {
            client = new MongoClient();
            UserDatabase = client.GetDatabase("ControlWorkDB");
            UsersCollection = UserDatabase.GetCollection<User>("Users");
        }
        public static void AddToDB(User newUser)
        {
            UsersCollection.InsertOne(newUser);
        }
        public static User Find(string Login)
        {
            return UsersCollection.Find(x => x.Login == Login).FirstOrDefault();
        }

        public static void ReplacePerson(string Login, User newUser)
        {
            UsersCollection.ReplaceOne(x => x.Login == Login, newUser);
        }
    }
}
