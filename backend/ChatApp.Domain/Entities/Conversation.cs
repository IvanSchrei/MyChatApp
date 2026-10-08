namespace ChatApp.Domain.Entities;
public class Conversation
{
    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public ICollection<ConversationParticipant> Participants { get; private set; } = [];

    public Conversation(Guid id)
    {
        Id = id;
        CreatedAt = DateTime.UtcNow;
    }

    private Conversation()
    {
        
    }
}