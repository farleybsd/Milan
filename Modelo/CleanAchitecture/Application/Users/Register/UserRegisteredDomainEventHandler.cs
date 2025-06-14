﻿using Domain.Users;
using SharedKernel;

namespace Application.Users.Register;
internal sealed class UserRegisteredDomainEventHandler : IDomainEventHandler<UserRegisteredDomainEvent> // Magia Aqui
{
    public Task Handle(UserRegisteredDomainEvent domainEvent, CancellationToken cancellationToken)
    {
        // TODO: Send an email verification link, etc.
        return Task.CompletedTask;
    }
}

