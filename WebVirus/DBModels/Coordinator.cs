using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace WebVirus.DBModels;

public partial class Coordinator
{
    [Key]
    public long CoordinatorId { get; set; }

    [Required(ErrorMessage = "Ingrese su nombre.")]
    [MaxLength(50, ErrorMessage = "Ingrese un maximo de 50 caracteres.")]
    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Solo se permiten letras y espacios.")]
    public string Name { get; set; } = null!;
    
    [Required(ErrorMessage = "Ingrese sus apellidos.")]
    [MaxLength(50, ErrorMessage = "Ingrese un maximo de 50 caracteres.")]
    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Solo se permiten letras y espacios.")]
    public string LastName { get; set; } = null!;
    
    [Required(ErrorMessage = "Ingrese su contraseña.")]
    [MinLength(8, ErrorMessage = "Ingrese un minimo de 8 caracteres.")]
    [MaxLength(50, ErrorMessage = "Ingrese un maximo de 50 caracteres.")]
    [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]+$", ErrorMessage = "La contraseña debe contener al menos una letra mayúscula, una letra minúscula, un número y un carácter especial.")]
    public string Password { get; set; } = null!;
    
    [ForeignKey("User")]
    public long UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
