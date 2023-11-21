namespace UserData.Data;

//! Este codigo es para CREAR CUENTA (AlMACENISTA)

public class User
{
   public string? UserID { get; set;}
   public string? Username { get; set; }
   public string? EncryptedPassword { get; set; }


   public User()
   {

   }

   public User(string userid, string username, string encryptedPassword)
   {
      UserID = userid;
      Username = username;
      EncryptedPassword = encryptedPassword;
   }
}

