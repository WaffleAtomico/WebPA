using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebVirus.DBModels;

public partial class Subject
{
    [Key]
    public long SubjectsId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Professor> Professors { get; set; } = new List<Professor>();
}
