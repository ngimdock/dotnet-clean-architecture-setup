using Domain.Abstractions;
using Domain.Entities;

public sealed class WebinarRepository : IWebinarRepository
{

  private readonly ApplicationDbContext _applicationDbContext;

  public WebinarRepository(ApplicationDbContext applicationDbContext){
    _applicationDbContext = applicationDbContext;
  }
  public void insert(Webinar webinar)
  {
    throw new NotImplementedException();
  }
}