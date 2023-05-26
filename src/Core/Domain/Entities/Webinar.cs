using System;

using Domain.Primitives;

namespace Domain.Entities;


public sealed class Webinar: Entity {


  public Webinar(Guid id, string name, DateTime scheduledOn){
    Name = name;
    ScheduledOn = scheduledOn;
  }

  public string Name { get; private set; }

  public DateTime ScheduledOn { get; private set; }
}

