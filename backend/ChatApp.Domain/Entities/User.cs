namespace ChatApp.Domain.Entities;
public class User
{
    public Guid Id { get; private set; }
    public string Username { get; private set; }

    public ICollection<ConversationParticipant> Conversations { get; private set; } = [];

    public User(Guid id, string username)
    {
        Id = id;
        Username = username;
    }

    private User()
    {
        
    }
}