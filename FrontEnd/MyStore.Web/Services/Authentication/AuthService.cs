
namespace MyStore.Web;

public class AuthService : IAuthService
{
    readonly HttpClient client = new();
    readonly string URL = "https://localhost:7059";

    public async Task AssignRoleAsync(RegisterDTO registerDTO)
    {
        try
        {
            var response = await client.PostAsJsonAsync(URL + "/assign", registerDTO);
        }
        catch (HttpRequestException e)
        {

            throw new HttpRequestException(e.Message);
        }
    }

    public async Task LoginAsync(LoginDTO loginDTO)
    {
        try
        {
            var response = await client.PostAsJsonAsync(URL + "/login", loginDTO);
        }
        catch (HttpRequestException e)
        {

            throw new HttpRequestException(e.Message);
        }
    }

    public async Task RegisterAsync(RegisterDTO registerDTO)
    {
        try
        {
            var response = await client.PostAsJsonAsync(URL + "/register", registerDTO);
        }
        catch (HttpRequestException e)
        {

            throw new HttpRequestException(e.Message);
        }
    }
}
