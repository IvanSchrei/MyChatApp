public record CreateConversationCommand(
    Guid ConversationId,
    List<Guid> ParticipantsId
);