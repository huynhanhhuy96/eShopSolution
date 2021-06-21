namespace eShopSolution.Application.System.Users
{
    using eShopSolution.ViewModels.Common;
    using eShopSolution.ViewModels.System.Users;
    using global::System.Threading.Tasks;

    public interface IUsersService
    {
        Task<string> Authencate(LoginRequest request);

        Task<bool> Register(RegisterRequest request);

        Task<PageResult<UserVm>> GetUsersPaging(GetUserPagingRequest request);
    }
}