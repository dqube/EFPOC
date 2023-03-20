using System;
using System.Collections.Generic;


namespace ClassLibrary1.Models;

public class OutboxMessage
{
public OutboxMessage(
    Guid id,  
    string type,  
    string content,  
    DateTime occurredOnUtc,  
    DateTime? processedOnUtc,  
    string error  
)
{
    Id = id;  
    Type = type;  
    Content = content;  
    OccurredOnUtc = occurredOnUtc;  
    ProcessedOnUtc = processedOnUtc;  
    Error = error;  
}
public Guid Id { get; private set; }

public string Type { get; private set; } = null!;

public string Content { get; private set; } = null!;

public DateTime OccurredOnUtc { get; private set; }

public DateTime? ProcessedOnUtc { get; private set; }

public string? Error { get; private set; }
public static OutboxMessage Create(
Guid id,  
string type,  
string content,  
DateTime occurredOnUtc,  
DateTime? processedOnUtc,  
string error  
 )
 {
 var outboxmessage = new OutboxMessage(
  id,  
  type,  
  content,  
  occurredOnUtc,  
  processedOnUtc,  
  error  
  );
 return outboxmessage;
  }
}
