using Conversations.API.Entities;
using MongoDB.Driver;

namespace Conversations.API.Data
{
    public class ConversationContext : IConversationContext
    {
        public ConversationContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var db = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));
            Conversations = db.GetCollection<Conversation>(configuration.GetValue<string>("DatabaseSettings:CollectionName1"));
            Messages = db.GetCollection<Message>(configuration.GetValue<string>("DatabaseSettings:CollectionName2"));
            ConversationDBSeed.SeedData(Conversations);
        }
        public IMongoCollection<Conversation> Conversations { get; }
        public IMongoCollection<Message> Messages { get; set; }
    }
}
