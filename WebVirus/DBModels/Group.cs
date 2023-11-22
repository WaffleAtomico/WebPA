using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebVirus.DBModels;

public partial class Group
{
    [Key]
    public long ClusterId { get; set; }
    public string Name { get; set; } = null!;
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}