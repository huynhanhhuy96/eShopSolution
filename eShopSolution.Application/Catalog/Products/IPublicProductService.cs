namespace eShopSolution.Application.Catalog.Products
{
    using eShopSolution.ViewModels.Catalog.Products;
    using eShopSolution.ViewModels.Common;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPublicProductService
    {
        Task<PageResult<ProductViewModel>> GetAllByCatelogyId(GetPublicProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll(string languageId);
    }
}
