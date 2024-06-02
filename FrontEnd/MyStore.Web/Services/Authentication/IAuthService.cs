namespace MyStore.Web;

public interface IAuthService
{
    Task LoginAsync(LoginDTO loginDTO);
    Task RegisterAsync(RegisterDTO registerDTO);
    Task AssignRoleAsync(RegisterDTO registerDTO);
}