namespace eShopSolution.AdminApp.Services
{
    using eShopSolution.ViewModels.System.Users;
    using System.Threading.Tasks;

    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
    }
}