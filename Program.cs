using System;
using MongoDB.Driver;

namespace docker_101
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ConnectionString = "mongodb://mongo:27017";
            var client = new MongoClient(ConnectionString);
            var database = client.GetDatabase("presentation");
            var collection = database.GetCollection<Attendee>("attendees");

            var attendee = new Attendee("Peter David Faria", "this.is.not.a.real.email@gmail.com");

            collection.InsertOne(attendee);

            var result = collection.Find(FilterDefinition<Attendee>.Empty);
            Console.WriteLine($"{result.First().Name} is presenting!");
        }
    }
}
