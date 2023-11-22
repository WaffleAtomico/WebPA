using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebVirus.DBModels;

[Table("Type_maintenance")]
public partial class TypeMaintenance
{
    [Key]
    [Column("pk_maintenance")]
    public long PkMaintenance { get; set; }

    [Column("nombre", TypeName = "VARCHAR (50)")]
    public string? Nombre { get; set; }
}
