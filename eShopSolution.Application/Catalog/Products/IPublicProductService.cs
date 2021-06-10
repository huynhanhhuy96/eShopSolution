namespace eShopSolution.Application.Catalog.Products
{
    using eShopSolution.ViewModels.Catalog.Products;
    using eShopSolution.ViewModels.Catalog.Products.Public;
    using eShopSolution.ViewModels.Common;
    using System.Threading.Tasks;

    public interface IPublicProductService
    {
        Task<PageResult<ProductViewModel>> GetAllCatelogyId(GetProductPagingRequest request);
    }
}
