using System.ComponentModel.DataAnnotations;

namespace RetroModels;

public class User {
    [Key]
    public int UserID { get; set; }
    public string UserName { get; set; } = string.Empty;
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }

}