namespace eShopSolution.ViewModels.System.Users
{
    using eShopSolution.ViewModels.Common;

    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}