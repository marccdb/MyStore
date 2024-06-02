using System.ComponentModel.DataAnnotations;

namespace MyStore.Web;

public class RegisterDTO
{
    [Required]
    public string? Email { get; set; }
    [Required]
    public string? Password { get; set; }
}
