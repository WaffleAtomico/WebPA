namespace Storer.Shared;
public class Storer
{
    public int StorerID { get; set; }
    public int UserID { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Password { get; set; }

    public Storer()
    {
    }
    public Storer(int storerID, int userID, string name, string lastName, string password)
    {
        StorerID = storerID;
        UserID = userID;
        Name = name;
        LastName = lastName;
        Password = password;
    }
}
