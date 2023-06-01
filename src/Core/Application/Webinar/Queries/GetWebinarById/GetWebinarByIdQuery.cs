using System;
using Application.Abstractions.Messaging;

namespace Application.Webinar.Queries;

public sealed record GetWebinarByIdQuery(Guid webinarId): IQuery<WebinarResponse>; 