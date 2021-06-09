namespace eShopSolution.Application.Catalog.Products
{
    using eShopSolution.Application.Catalog.Products.Dtos;
    using eShopSolution.Application.Dtos;

    public interface IPublicProductService
    {
        public PageViewModel<ProductViewModel> GetAllCatelogyId(int categoryId, int pageIndex, int pageSize);
    }
}
