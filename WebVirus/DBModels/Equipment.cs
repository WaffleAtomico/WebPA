using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebVirus.DBModels;

public partial class Equipment
{
    [Key]
    public long EquipmentId { get; set; }

    [MaxLength(50)]
    public string Model { get; set; } = null!;

    [MaxLength(255)]
    public string Name { get; set; } = null!;

    [MaxLength(50)]
    public string Category { get; set; } = null!;

    [MaxLength(50)]
    public string Brand { get; set; } = null!;
    
    [MaxLength(50)]
    public string Serial { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<ReportMaintenance> ReportMaintenances { get; set; } = new List<ReportMaintenance>();
}
