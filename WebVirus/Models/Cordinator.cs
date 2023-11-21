namespace cordinator.Shared;

public class Cordinator {
    public string? name {get; set;}
    public string? lastname {get; set;}
    public string? idCredential {get; set;}
    public string? password {get; set;}

    public Cordinator ()
    {

    }

    public Cordinator (string name, string lastname, string idCredential, string password)
    {
        this.name = name;
        this.lastname = lastname;
        this.idCredential = idCredential;
        this.password = password;
    }
}