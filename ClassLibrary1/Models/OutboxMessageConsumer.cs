using System;
using System.Collections.Generic;


namespace ClassLibrary1.Models;

public class OutboxMessageConsumer
{
public OutboxMessageConsumer(
    Guid id,  
    string name  
)
{
    Id = id;  
    Name = name;  
}
public Guid Id { get; private set; }

public string Name { get; private set; } = null!;
public static OutboxMessageConsumer Create(
Guid id,  
string name  
 )
 {
 var outboxmessageconsumer = new OutboxMessageConsumer(
  id,  
  name  
  );
 return outboxmessageconsumer;
  }
}
