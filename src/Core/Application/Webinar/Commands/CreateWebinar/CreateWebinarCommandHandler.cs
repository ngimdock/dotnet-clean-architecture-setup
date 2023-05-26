using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Abstractions.Messaging;
using Domain.Abstractions;
using Domain.Entities;

namespace Application.Webinar.Commands.CreateWebinar;


internal sealed class CreateWebinarCommandHandler: ICommandHandler<CreateWebinerCommand, Guid> {

  private readonly IWebinarRepository _webinarRepository;
  private readonly IUnitOfWork _unitOfWork;


  public CreateWebinarCommandHandler(IWebinarRepository webinarRepository, IUnitOfWork unitOfWork){
    
    _webinarRepository = webinarRepository;
    _unitOfWork = unitOfWork;
  }


  public async Task<Guid> Handle(CreateWebinarCommand request, CancellationToken cancellationToken) {

    var webinar = new Webinar(Guid.NewGuid(), request.Name, request.ScheduledOn);

    _webinarRepository.insert(webinar);

    await _unitOfWork.SaveChangeAsync(cancellationToken);

    return webinar.id;
  }
}