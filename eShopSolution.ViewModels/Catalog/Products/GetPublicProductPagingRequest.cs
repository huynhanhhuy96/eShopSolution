namespace eShopSolution.ViewModels.Catalog.Products
{
    using eShopSolution.ViewModels.Common;

    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
