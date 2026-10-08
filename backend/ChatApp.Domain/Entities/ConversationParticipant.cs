namespace ChatApp.Domain.Entities;

public class ConversationParticipant
{
    public Guid ConversationId { get; private set; }
    public Guid UserId { get; private set; }
    public Conversation Conversation { get; private set; } = null!;
    public User User { get; private set; } = null!;

    public ConversationParticipant(Guid conversationId, Guid userId)
    {
        ConversationId = conversationId;
        UserId = userId;
    }

    private ConversationParticipant()
    {
        
    }
}