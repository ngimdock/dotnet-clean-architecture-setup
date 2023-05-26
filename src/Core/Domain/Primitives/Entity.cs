using System;

namespace Domain.Primitives;

public abstract class Entity {
  public Guid Id;


  protected Entity(Guid id) => Id = id;

  protected Entity() {}
  
}