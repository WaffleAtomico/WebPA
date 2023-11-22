using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebVirus.DBModels;

public partial class User
{
    [Key]
    public long UserId { get; set; }

    public string User1 { get; set; } = null!;

    [Required(ErrorMessage = "Ingrese su contraseña.")]
    [MinLength(8, ErrorMessage = "Ingrese un minimo de 8 caracteres.")]
    [MaxLength(50, ErrorMessage = "Ingrese un maximo de 50 caracteres.")]
    [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]+$", ErrorMessage = "La contraseña debe contener al menos una letra mayúscula, una letra minúscula, un número y un carácter especial.")]
    public string Password { get; set; } = null!;

    public virtual ICollection<Coordinator> Coordinators { get; set; } = new List<Coordinator>();

    public virtual ICollection<Professor> Professors { get; set; } = new List<Professor>();

    public virtual ICollection<Storer> Storers { get; set; } = new List<Storer>();
}
