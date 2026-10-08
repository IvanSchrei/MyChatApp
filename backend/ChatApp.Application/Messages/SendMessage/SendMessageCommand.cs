public record SendMessageCommand(
    Guid SenderId,
    Guid ConversationId,
    string Content
);