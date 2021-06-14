namespace eShopSolution.Application.Catalog.Products
{
    using eShopSolution.ViewModels.Catalog.Products;
    using eShopSolution.ViewModels.Common;
    using global::System.Collections.Generic;
    using global::System.Threading.Tasks;

    public interface IPublicProductService
    {
        Task<PageResult<ProductViewModel>> GetAllByCatelogyId(string languageId, GetPublicProductPagingRequest request);
    }
}