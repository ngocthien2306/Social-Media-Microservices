using Conversations.API.Entities;
using MongoDB.Driver;

namespace Conversations.API.Data
{
    public class ConversationDBSeed
    {
        public static void SeedData(IMongoCollection<Conversation> mongoCollection)
        {
            bool existConversation = mongoCollection.Find(p => true).Any();
            if(!existConversation)
            {               
                mongoCollection.InsertManyAsync(GetDefualtsConversations()); 
            }
        }

        private static List<Conversation> GetDefualtsConversations()
        {
            return new List<Conversation>()
            {
                new Conversation()
                {
                    Members = new List<string>{"1", "2"},
                    Messages = new List<Message>()
                    {
                        new Message()
                        {                       
                            SenderID = "1",
                            MessagesType = "Text",
                            MessageText = "Hello Thien Nguyen",
                            Timestamp = DateTime.Now,
                            AttachmentThumbUrl = "no",
                            AttachmentUrl = "no"
                        },
                        new Message()
                        {
                            SenderID = "1",
                            MessagesType = "Text",
                            MessageText = "How do you feel!",
                            Timestamp = DateTime.Now,
                            AttachmentThumbUrl = "no",
                            AttachmentUrl = "no"
                        },
                        new Message()
                        {
                            SenderID = "2",
                            MessagesType = "Text",
                            MessageText = "Hi, I'm ok",
                            Timestamp = DateTime.Now,
                            AttachmentThumbUrl = "no",
                            AttachmentUrl = "no"
                        }
                    },
                    Time = DateTime.Now,
                },

                new Conversation()
                {
                    Members = new List<string>{"3", "4"},
                    Messages = new List<Message>()
                    {
                        new Message()
                        {
                            SenderID = "3",
                            MessagesType = "Text",
                            MessageText = "Alo bro",
                            Timestamp = DateTime.Now,
                            AttachmentThumbUrl = "no",
                            AttachmentUrl = "no"
                        },
                        new Message()
                        {
                            SenderID = "4",
                            MessagesType = "Text",
                            MessageText = "Nghe bro",
                            Timestamp = DateTime.Now,
                            AttachmentThumbUrl = "no",
                            AttachmentUrl = "no"
                        },
                        new Message()
                        {
                            SenderID = "4",
                            MessagesType = "Text",
                            MessageText = "Noi di",
                            Timestamp = DateTime.Now,
                            AttachmentThumbUrl = "no",
                            AttachmentUrl = "no"
                        }
                    },
                    Time = DateTime.Now,
                }
            };
        }
    }
}
