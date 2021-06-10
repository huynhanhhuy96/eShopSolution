namespace eShopSolution.Application.Catalog.Products.Dtos.Public
{
    using eShopSolution.Application.Dtos;

    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
