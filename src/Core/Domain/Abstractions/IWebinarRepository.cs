using Domain.Entities;

namespace Domain.Abstractions;

public interface IWebinarRepository {

  void insert(Webinar webinar);
}