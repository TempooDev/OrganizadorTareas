using MediatR;

public record GetTodosByIdQuery(int Id): IRequest<Todo>{}
