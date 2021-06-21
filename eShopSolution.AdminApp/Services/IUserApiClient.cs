namespace eShopSolution.AdminApp.Services
{
    using eShopSolution.ViewModels.Common;
    using eShopSolution.ViewModels.System.Users;
    using System.Threading.Tasks;

    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);

        Task<PageResult<UserVm>> GetUsersPagings(GetUserPagingRequest request);

        Task<bool> RegisterUser(RegisterRequest registerRequest);
    }
}