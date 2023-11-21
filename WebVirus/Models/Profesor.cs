namespace ProfessorData.Data;
public class Profesor
{
    public string? UserProfesor {get; set;}
    public string? PayRollNumber {get; set;}
    public string? EncryptedPassword {get; set;}
    public string? Subjects {get; set;}

    public Profesor ()
    {

    }

    public Profesor (string userprofesor, string payrollnumber, string encryptedpassword, string subjects)
    {
        UserProfesor = userprofesor;
        PayRollNumber = payrollnumber;
        EncryptedPassword = encryptedpassword;
        Subjects = subjects;
    }
}