namespace eShopSolution.Application.Catalog.Products
{
    using eShopSolution.Application.Catalog.Products.Dtos;
    using eShopSolution.Application.Catalog.Products.Dtos.Manage;
    using eShopSolution.Application.Dtos;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addQuantity);

        Task AddViewCount(int productId);

        Task<PageResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }
}
