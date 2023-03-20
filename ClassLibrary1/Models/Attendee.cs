using System;
using System.Collections.Generic;


namespace ClassLibrary1.Models;

public class Attendee
{
public Attendee(
    Guid gatheringId,  
    Guid memberId,  
    DateTime createdOnUtc  
)
{
    GatheringId = gatheringId;  
    MemberId = memberId;  
    CreatedOnUtc = createdOnUtc;  
}
public Guid GatheringId { get; private set; }

public Guid MemberId { get; private set; }

public DateTime CreatedOnUtc { get; private set; }

public Gathering Gathering { get; private set; } = null!;

public Member Member { get; private set; } = null!;
public static Attendee Create(
Guid gatheringId,  
Guid memberId,  
DateTime createdOnUtc  
 )
 {
 var attendee = new Attendee(
  gatheringId,  
  memberId,  
  createdOnUtc  
  );
 return attendee;
  }
}
