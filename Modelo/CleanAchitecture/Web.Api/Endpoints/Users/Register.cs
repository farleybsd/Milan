
using Application.Abstractions.Messaging;
using Application.Users.Register;
using SharedKernel;
using Web.Api.Extensions;
using Web.Api.Infrastructure;

namespace Web.Api.Endpoints.Users;
internal sealed class Register : IEndpoint
{
    public sealed record Request(string Email, string FirstName, string LastName, string Password);
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("users/register", async (Request request,
             ICommandHandler<RegisterUserCommand, Guid> handler,
              CancellationToken cancellationToken) =>
        {
            var command = new RegisterUserCommand(
               request.Email,
               request.FirstName,
               request.LastName,
               request.Password);

            Result<Guid> result = await handler.Handle(command, cancellationToken);

            // Resposta com base no resultado
            return result.Match(
            onSuccess: id => Results.Created($"/users/{id}", new { id }),
            onFailure: CustomResults.Problem);

        }).WithTags(Tags.Users);
        
    }
}
