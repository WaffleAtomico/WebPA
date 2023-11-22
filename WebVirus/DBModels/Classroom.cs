using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebVirus.DBModels;

[Table("classroom")]
public partial class Classroom
{
    [Key]
    public long Classroomid { get; set; }

    [Column("nombre", TypeName = "VARCHAR (255)")]
    public string? Nombre { get; set; }
}
