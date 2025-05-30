using Application.Abstractions.Messaging;
using SharedKernel;

namespace Application.Todos.Create;

internal sealed class CreateTodoCommandHandler : ICommandHandler<CreateTodoCommand, Guid>
{
    public Task<Result<Guid>> Handle(CreateTodoCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
