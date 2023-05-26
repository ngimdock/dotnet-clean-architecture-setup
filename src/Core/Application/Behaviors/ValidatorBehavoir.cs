


// Here we use a librairie call mediator for the CQRS pattern

// mediator have concept of pipeline who is same like "Middleware"

// mediator allow us to wrap CommandQueryHandler and execute some company logic

// In this case we are validating the command we have send using the mediator and if there is and error we throw ValidationException

// The ValidationException is handle in the upper layer


public sealed class ValidationBehavior<TRequest, TResponse>: IpipelineBehavior<TRequest, TResponse>
  where TRequest: class, ICommand<TResponse> {


    // see the code in the video
  }