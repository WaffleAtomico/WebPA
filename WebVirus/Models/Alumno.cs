namespace alumno.Shared;

public class AlumnoUser
{
    public string? Alumnouser {get; set;}
    public string? LastName {get; set;}
    public string? Register {get; set;}
    public string? PasswordEncrypted {get; set;}
    public string? Group {get; set;}
    

    public AlumnoUser ()
    {

    }

    public AlumnoUser (string alumnouser, string lastname, string register, string passwordencrypted, string group)
    {
        Alumnouser = alumnouser;
        LastName = lastname;
        Register = register;
        PasswordEncrypted = passwordencrypted;
        Group = group;
   
    }
}