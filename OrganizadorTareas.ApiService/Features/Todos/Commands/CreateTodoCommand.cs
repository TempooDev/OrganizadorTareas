using MediatR;

public record CreateTodoCommand (string Name, string Description, DateTime? ExpectedDate, DateTime CreatedDate ): IRequest<Todo>;