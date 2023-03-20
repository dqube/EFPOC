using System;
using System.Collections.Generic;


namespace ClassLibrary1.Models;

public class Invitation
{
public Invitation(
    Guid id,  
    Guid gatheringId,  
    Guid memberId,  
    int status,  
    DateTime createdOnUtc,  
    DateTime? modifiedOnUtc  
)
{
    Id = id;  
    GatheringId = gatheringId;  
    MemberId = memberId;  
    Status = status;  
    CreatedOnUtc = createdOnUtc;  
    ModifiedOnUtc = modifiedOnUtc;  
}
public Guid Id { get; private set; }

public Guid GatheringId { get; private set; }

public Guid MemberId { get; private set; }

public int Status { get; private set; }

public DateTime CreatedOnUtc { get; private set; }

public DateTime? ModifiedOnUtc { get; private set; }

public Gathering Gathering { get; private set; } = null!;

public Member Member { get; private set; } = null!;
public static Invitation Create(
Guid id,  
Guid gatheringId,  
Guid memberId,  
int status,  
DateTime createdOnUtc,  
DateTime? modifiedOnUtc  
 )
 {
 var invitation = new Invitation(
  id,  
  gatheringId,  
  memberId,  
  status,  
  createdOnUtc,  
  modifiedOnUtc  
  );
 return invitation;
  }
}
