
using Application.Webinar.Queries;
using Application.Webinar.Commands;
using Microsoft.AspNetCore.Http;

public sealed class WebinarController {

  [HttpGet("{webinarId: guid}")]
  public async Task<IActionResult> GerWebinar(Guid webinarId, CancellationToken cancellationToken){
    
    var query = new GetWebinarByIdQuery(webinarId);

    var webinar = Sender.Send(query, cancellationToken);

    return Ok(webinar);
  }

  [HttpPost]
  public async Task<IActionResult> CreateWebinar( 
    [FromBody] CreateWebinarRequest request,
    CancellationToken cancellationToken  
  ) {

      var command = request.Adapt<CreateWebinarCommand>();

      var webinarId = await Sender.Send(command, cancellationToken);

      return CreatedAction(nameof(GetWebinar), new { webinarId }, webinarId)
  }
}
