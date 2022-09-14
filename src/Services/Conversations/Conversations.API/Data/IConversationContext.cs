using Conversations.API.Entities;
using MongoDB.Driver;

namespace Conversations.API.Data
{
    public interface IConversationContext
    {
        IMongoCollection<Conversation> Conversations { get; }
        IMongoCollection<Message> Messages { get; }
    }
}
