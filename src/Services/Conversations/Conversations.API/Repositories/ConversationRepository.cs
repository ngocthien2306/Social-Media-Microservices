using Conversations.API.Data;
using Conversations.API.Entities;
using MongoDB.Driver;

namespace Conversations.API.Repositories
{
    public class ConversationRepository : IConversationRepository
    {
        private readonly  IConversationContext _context;

        public ConversationRepository(IConversationContext conversationContext)
        {
            _context = conversationContext;
        }

        public async Task CreateConversation(Conversation conversation)
        {
            await _context.Conversations.InsertOneAsync(conversation);
        }

        public Task<bool> DeleteConversation(string conversationId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Conversation>> GetConversations()
        {
            return await _context.Conversations.Find(p => true).ToListAsync();
        }

        public async Task<Conversation> GetConversationsById(string conversationId)
        {
            return await _context.Conversations.Find(p => p.ConversationID == conversationId).FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateConversation(Conversation conversation)
        {
            FilterDefinition<Conversation> filter = Builders<Conversation>.Filter.Eq(c => c.ConversationID, conversation.ConversationID);
            var updateResult = await _context.Conversations.ReplaceOneAsync(filter: filter, replacement: conversation);
            return updateResult.IsAcknowledged && updateResult.MatchedCount > 0;
        }
    }
}
