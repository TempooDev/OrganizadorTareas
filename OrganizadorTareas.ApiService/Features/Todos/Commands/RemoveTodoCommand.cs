using MediatR;

public record RemoveTodoCommand(int Id): IRequest;