using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebVirus.DBModels;

public partial class Order{

    [Key]
    public long Idorder { get; set; }

    public byte[] Date { get; set; } = null!;

    public byte[] DeliveryTime { get; set; } = null!;

    public byte[] ReturnTime { get; set; } = null!;

    public long FkStudent { get; set; }

    public long FkProfessor { get; set; }

    public long? Classroomfk { get; set; }

    public long? Fkequipment { get; set; }

    public virtual Professor FkProfessorNavigation { get; set; } = null!;

    public virtual Student FkStudentNavigation { get; set; } = null!;

    public virtual Equipment? FkequipmentNavigation { get; set; }

}