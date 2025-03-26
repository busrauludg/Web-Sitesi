namespace Entities.Models;

public class User
{
    public int UserId { get; set; }
    public String? UserName { get; set; } = String.Empty;
    public String? Email { get; set; } = String.Empty;
    //public String? Password { get; set; } = String.Empty;

    public string Password { get; set; }

    public string PasswordLength => Password?.Length.ToString() ?? "0"; // Null kontrolü de ekledim


}
