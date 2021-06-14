namespace eShopSolution.Application.System.Users
{
    using eShopSolution.ViewModels.System.Users;
    using global::System.Threading.Tasks;

    public interface IUsersService
    {
        Task<string> Authencate(LoginRequest request);

        Task<bool> Register(RegisterRequest request);
    }
}