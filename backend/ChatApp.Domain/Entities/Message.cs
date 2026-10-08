namespace ChatApp.Domain.Entities;
public class Message
{
    public Guid Id { get; private set; }
    public Guid SenderId { get; private set; }
    public Guid ConversationId { get; private set; }
    public DateTime SentAt { get; private set; }
    public string Content { get; private set; }
    public User Sender { get; private set; } = null!;
    public Conversation Conversation { get; private set; } = null!;

    public Message(Guid id, Guid senderId, Guid conversationId, string content)
    {
        Id = id;
        SenderId = senderId;
        ConversationId = conversationId;
        SentAt = DateTime.UtcNow;
        Content = content;   
    }
}