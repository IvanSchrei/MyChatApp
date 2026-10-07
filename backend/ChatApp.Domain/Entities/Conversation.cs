public class Conversation
{
    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public List<Guid> ParticipantIds { get; private set; }
}