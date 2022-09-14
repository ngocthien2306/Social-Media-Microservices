using Conversations.API.Entities;

namespace Conversations.API.Repositories
{
    public interface IConversationRepository
    {
        Task<List<Conversation>> GetConversations();
        Task<Conversation> GetConversationsById(string conversationId);
        Task CreateConversation(Conversation conversation);
        Task<bool> UpdateConversation(Conversation conversation);
        Task<bool> DeleteConversation(string conversationId);
    }
}
