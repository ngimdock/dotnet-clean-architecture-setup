using System;
using Application.Abstractions.Messaging;

namespace Application.Webinar.Commands.CreateWebinar;

public sealed record CreateWebinarCommand(string Name, DateTime ScheduledOn): ICommand<Guid>;