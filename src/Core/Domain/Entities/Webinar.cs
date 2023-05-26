using System;

using Domain.Primitives;

namespace Domain.Entities;


public sealed class Webinar: Entity {


  public Webinar(string id, string name, DateTime scheduledOn){
    Name = name;
    ScheduledOn = scheduledOn;

    Console.WriteLine("constructor....");
  }

  private Webinar() {}

  public string Name { get; private set; }

  public DateTime ScheduledOn { get; private set; }
}

