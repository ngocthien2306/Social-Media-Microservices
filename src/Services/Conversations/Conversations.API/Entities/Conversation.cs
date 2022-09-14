using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Conversations.API.Entities
{
    public class Conversation
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ConversationID { get; set; } = null!;
        [BsonElement("Time")]
        public DateTime Time { get; set; }
        public List<string> Members { get; set; } = null!;
        public List<Message> Messages { get; set; } = new List<Message>();
        public int TotalMessage { get
            {
                int total = 0;
                foreach (var message in Messages)
                {
                    total++;
                }
                return total;
            }
        }

    }
}
