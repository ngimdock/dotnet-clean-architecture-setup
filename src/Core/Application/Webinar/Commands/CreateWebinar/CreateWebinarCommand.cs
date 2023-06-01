using System;
using Application.Abstractions.Messaging;

namespace Application.Webinar.Commands;

public sealed record CreateWebinarCommand(string Name, DateTime ScheduledOn): ICommand<Guid>;