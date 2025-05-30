namespace Application.Abstractions.Messaging;

public interface IBaseCommand;

public interface ICommand<TResponse> : IBaseCommand;
