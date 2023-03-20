using System;
using System.Collections.Generic;


namespace ClassLibrary1.Models;

public class Role
{
public Role(
    int id,  
    string name  
)
{
    Id = id;  
    Name = name;  
}
public int Id { get; private set; }

public string Name { get; private set; } = null!;

public virtual ICollection<Member> Members { get; set; } = new List<Member>();

public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
public static Role Create(
int id,  
string name  
 )
 {
 var role = new Role(
  id,  
  name  
  );
 return role;
  }
}
