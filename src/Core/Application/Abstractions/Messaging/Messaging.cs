using System;
using MediatR;

namespace Application.Abstractions.Messaging
{
    public interface ICommand<T> : IRequest<T>
    {
      Guid Id { get; }
      DateTime Timestamp { get; }
      
      T Data { get; }
    }
}

