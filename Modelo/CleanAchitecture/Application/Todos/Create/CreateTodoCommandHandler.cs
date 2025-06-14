using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Todos;
using SharedKernel;

namespace Application.Todos.Create;

internal sealed class CreateTodoCommandHandler(
   // IApplicationDbContext _context,
   // IDateTimeProvider dateTimeProvider
    ) : ICommandHandler<CreateTodoCommand, Guid>
{
    //public  async Task<Result<Guid>> Handle(CreateTodoCommand command, CancellationToken cancellationToken)
    //{
    //    // Todo User


    //    var todoItem = new TodoItem
    //    {
    //        //UserId = user.Id,
    //        Description = command.Description,
    //        Priority = command.Priority,
    //        DueDate = command.DueDate,
    //        Labels = command.Labels,
    //        IsCompleted = false,
    //        CreatedAt = dateTimeProvider.UtcNow
    //    };

    //    todoItem.Raise(new TodoItemCreatedDomainEvent(todoItem.Id));

    //    _context.TodoItems.Add(todoItem);

    //    await _context.SaveChangesAsync(cancellationToken);

    //    return todoItem.Id;
    //}
    public Task<Result<Guid>> Handle(CreateTodoCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
