using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Authorization.Data
{
    public class User
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        [BsonIgnoreIfNull]
        public string login { get; set; }
        [BsonIgnoreIfNull]
        public string password { get; set; }
        [BsonIgnoreIfNull]
        public string name { get; set; }
        [BsonIgnoreIfNull]
        public string surname { get; set; }
        [BsonIgnoreIfNull]
        public string email { get; set; }

        /*
        public User(string newLogin, string newPassword, string newName, string newSurname, string newEmail)
        {
            login = newLogin;
            password = newPassword;
            name = newName;
            surname = newSurname;
            email = newEmail;
        }
        */
    }
}