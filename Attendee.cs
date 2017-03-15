using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace docker_101
{
    public class Attendee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        public string Name { get; set; }

        public string Email { get; set; }
        public Attendee(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }
    }
}