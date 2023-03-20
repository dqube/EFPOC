using System;
using System.Collections.Generic;


namespace ClassLibrary1.Models;

public class Gathering
{
private readonly List<Attendee> _attendees = new();
private readonly List<Invitation> _invitations = new();
public Gathering(
    Guid id,  
    Guid creatorId,  
    int type,  
    string name,  
    DateTime scheduledAtUtc,  
    string location,  
    int? maximumNumberOfAttendees,  
    DateTime? invitationsExpireAtUtc,  
    int numberOfAttendees  
)
{
    Id = id;  
    CreatorId = creatorId;  
    Type = type;  
    Name = name;  
    ScheduledAtUtc = scheduledAtUtc;  
    Location = location;  
    MaximumNumberOfAttendees = maximumNumberOfAttendees;  
    InvitationsExpireAtUtc = invitationsExpireAtUtc;  
    NumberOfAttendees = numberOfAttendees;  
}
public Guid Id { get; private set; }

public Guid CreatorId { get; private set; }

public int Type { get; private set; }

public string Name { get; private set; } = null!;

public DateTime ScheduledAtUtc { get; private set; }

public string? Location { get; private set; }

public int? MaximumNumberOfAttendees { get; private set; }

public DateTime? InvitationsExpireAtUtc { get; private set; }

public int NumberOfAttendees { get; private set; }

   public IReadOnlyCollection<Attendee> Attendees => _attendees;

public Member Creator { get; private set; } = null!;

   public IReadOnlyCollection<Invitation> Invitations => _invitations;
public static Gathering Create(
Guid id,  
Guid creatorId,  
int type,  
string name,  
DateTime scheduledAtUtc,  
string location,  
int? maximumNumberOfAttendees,  
DateTime? invitationsExpireAtUtc,  
int numberOfAttendees  
 )
 {
 var gathering = new Gathering(
  id,  
  creatorId,  
  type,  
  name,  
  scheduledAtUtc,  
  location,  
  maximumNumberOfAttendees,  
  invitationsExpireAtUtc,  
  numberOfAttendees  
  );
 return gathering;
  }
}
