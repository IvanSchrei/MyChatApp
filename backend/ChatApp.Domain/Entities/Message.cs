public class Message
{
    public Guid Id { get; private set; }
    public Guid SenderId { get; private set; }
    public Guid ConversationId { get; private set; }
    public DateTime SentAt { get; private set; }
    public string Content { get; private set; }
}