using System;

using Domain.Exceptions.Base;

public sealed class WebinarNotFoundException: NotFoundException {


  public WebinarNotFoundException(Guid webinarId): base($"The webinar with the id {webinarId} was not found.") 
  {}
}