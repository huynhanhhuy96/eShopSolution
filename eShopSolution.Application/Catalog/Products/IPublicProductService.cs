namespace eShopSolution.Application.Catalog.Products
{
    using eShopSolution.Application.Catalog.Products.Dtos;
    using eShopSolution.Application.Catalog.Products.Dtos.Public;
    using eShopSolution.Application.Dtos;
    using System.Threading.Tasks;

    public interface IPublicProductService
    {
        Task<PageResult<ProductViewModel>> GetAllCatelogyId(GetProductPagingRequest request);
    }
}
