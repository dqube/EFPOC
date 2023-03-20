using System;
using System.Collections.Generic;


namespace ClassLibrary1.Models;

public class Permission
{
public Permission(
    int id,  
    string name  
)
{
    Id = id;  
    Name = name;  
}
public int Id { get; private set; }

public string Name { get; private set; } = null!;

public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
public static Permission Create(
int id,  
string name  
 )
 {
 var permission = new Permission(
  id,  
  name  
  );
 return permission;
  }
}
