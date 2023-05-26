using System;
using Application.Abstractions.Messaging;

namespace Application.Webinar.Queries.GetWebinarById;

public sealed record GetWebinarByIdQuery(Guid webinarId): IQuery<WebinarResponse>; 