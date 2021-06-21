namespace eShopSolution.Application.Catalog.Products
{
    using eShopSolution.ViewModels.Catalog.ProductImages;
    using eShopSolution.ViewModels.Catalog.Products;
    using eShopSolution.ViewModels.Common;
    using global::System.Collections.Generic;
    using global::System.Threading.Tasks;

    public interface IProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<ProductViewModel> GetById(int productId, string languageId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addQuantity);

        Task AddViewCount(int productId);

        Task<PageResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImage(int productId, ProductImageCreateRequest request);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);

        Task<List<ProductImageViewModel>> GetListImages(int productId);

        Task<ProductImageViewModel> GetImageById(int imageId);

        Task<PageResult<ProductViewModel>> GetAllByCatelogyId(string languageId, GetPublicProductPagingRequest request);
    }
}