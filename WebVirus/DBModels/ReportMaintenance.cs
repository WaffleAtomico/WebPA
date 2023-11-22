using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebVirus.DBModels;

[Table("Report Maintenance")]
public partial class ReportMaintenance
{
    [Key]
    [Column("pk_MaintenanceR")]
    public long PkMaintenanceR { get; set; }

    [Column("fk_equipment")]
    public long FkEquipment { get; set; }

    [Column("fk_Maintenance")]
    public long FkMaintenance { get; set; }

    [Column("date", TypeName = "date")]
    public byte[] Date { get; set; } = null!;

    [ForeignKey("FkEquipment")]
    [InverseProperty("ReportMaintenances")]
    public virtual Equipment FkEquipmentNavigation { get; set; } = null!;
}
