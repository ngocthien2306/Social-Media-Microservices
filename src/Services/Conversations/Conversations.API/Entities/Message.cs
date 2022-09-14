using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Conversations.API.Entities
{
    public class Message
    {
        public string SenderID { get; set; } = null!;
        public string MessagesType { get; set; } = null!;
        public string MessageText { get; set; } = null!;
        public string AttachmentThumbUrl { get; set; } = null!;
        public string AttachmentUrl { get; set; } = null!;
        public DateTime Timestamp { get; set; }
    }
    public enum MessageType {

    }
}
