using System;
using System.Collections.Generic;


namespace ClassLibrary1.Models;

public class Member
{
private readonly List<Attendee> _attendees = new();
private readonly List<Gathering> _gatherings = new();
private readonly List<Invitation> _invitations = new();
public Member(
    Guid id,  
    string email,  
    string firstName,  
    string lastName,  
    DateTime createdOnUtc,  
    DateTime? modifiedOnUtc  
)
{
    Id = id;  
    Email = email;  
    FirstName = firstName;  
    LastName = lastName;  
    CreatedOnUtc = createdOnUtc;  
    ModifiedOnUtc = modifiedOnUtc;  
}
public Guid Id { get; private set; }

public string Email { get; private set; } = null!;

public string FirstName { get; private set; } = null!;

public string LastName { get; private set; } = null!;

public DateTime CreatedOnUtc { get; private set; }

public DateTime? ModifiedOnUtc { get; private set; }

   public IReadOnlyCollection<Attendee> Attendees => _attendees;

   public IReadOnlyCollection<Gathering> Gatherings => _gatherings;

   public IReadOnlyCollection<Invitation> Invitations => _invitations;

public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
public static Member Create(
Guid id,  
string email,  
string firstName,  
string lastName,  
DateTime createdOnUtc,  
DateTime? modifiedOnUtc  
 )
 {
 var member = new Member(
  id,  
  email,  
  firstName,  
  lastName,  
  createdOnUtc,  
  modifiedOnUtc  
  );
 return member;
  }
}
