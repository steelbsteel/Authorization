using MongoDB.Driver;

namespace Authorization.Data
{
    public class DataBase
    {
        public DataBase() { }
        public void AddToDataBase(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Authorization");
            var collection = database.GetCollection<User>("UsersCollection");
            collection.InsertOne(user);
        }
    }
}
