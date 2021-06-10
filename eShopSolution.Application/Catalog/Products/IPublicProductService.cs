namespace eShopSolution.Application.Catalog.Products
{
    using eShopSolution.Application.Catalog.Products.Dtos;
    using eShopSolution.Application.Catalog.Products.Dtos.Manage;
    using eShopSolution.Application.Dtos;

    public interface IPublicProductService
    {
        public PageResult<ProductViewModel> GetAllCatelogyId(GetProductPagingRequest request);
    }
}
