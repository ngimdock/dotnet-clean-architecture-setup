using Drapper;
using Domain.Exceptions;
using Application.Abstractions.Messaging;

namespace Application.Webinar.Queries.GetWebinarById;


internal sealed class GetWebinarByIdQueryHandler: GetWebinarByIdQueryHandler<GetWebinarByIdQuery, WebinarResponse> {


  private readonly IDbConnection _dbConnection;

  public GetWebinarByIdQueryHandler(IDbConnection dbConnection) => _dbConnection = dbConnection;

  public async Task<WebinarResponse> Handle(GetWebinarByIdQuery request, CancellationToken cancellationToken) {

    const string sql = @"SELECT * FROM 'webinar' WHERE 'id' = @'webinarId'";

    var webinar = await _dbConnection.QueryFirstOrDefaultAsync(
      sql,
      new { request.webinarId }
    );

    if(webinar is null) 
      throw new WebinarNotFoundException(request.webinarId);
    
    return webinar;
  }
}