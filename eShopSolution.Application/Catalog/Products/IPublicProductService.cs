namespace eShopSolution.Application.Catalog.Products
{
    using eShopSolution.ViewModels.Catalog.Products;
    using eShopSolution.ViewModels.Common;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPublicProductService
    {
        Task<PageResult<ProductViewModel>> GetAllByCatelogyId(string languageId, GetPublicProductPagingRequest request);
    }
}