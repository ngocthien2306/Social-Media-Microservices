using Conversations.API.Entities;
using Conversations.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Conversations.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ConversationController : ControllerBase
    {
        private readonly IConversationRepository _conversationRepository;
        private readonly ILogger<ConversationController> _logger;

        public ConversationController(IConversationRepository conversationRepository, ILogger<ConversationController> logger)
        {
            _conversationRepository = conversationRepository;
            _logger = logger;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Conversation>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<List<Conversation>>> GetConversations()
        {
            var conversations = await _conversationRepository.GetConversations();
            return Ok(conversations);
        }

        [HttpPut]
        [ProducesResponseType(typeof(Conversation), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> UpdateConversation([FromBody] Conversation conversation)
        {
            return Ok( await _conversationRepository.UpdateConversation(conversation));
        }
    }
}
