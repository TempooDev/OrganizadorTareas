using MediatR;

record class GetAllTodosQuery: IRequest<Todo>{};