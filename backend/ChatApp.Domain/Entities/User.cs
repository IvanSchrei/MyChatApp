public class User
{
    public Guid Id { get; private set; }
    public string Username { get; private set; }

    public User()
    {
        this.Username = "default";
    }
}