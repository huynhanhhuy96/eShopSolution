namespace eShopSolution.ViewModels.Catalog.Products.Public
{
    using eShopSolution.ViewModels.Common;

    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
