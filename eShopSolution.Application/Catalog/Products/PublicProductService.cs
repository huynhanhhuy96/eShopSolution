namespace eShopSolution.Application.Catalog.Products
{
    using eShopSolution.Data.EF;
    using eShopSolution.ViewModels.Catalog.Products;
    using eShopSolution.ViewModels.Common;
    using Microsoft.EntityFrameworkCore;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;

    public class PublicProductService : IPublicProductService
    {
        private readonly EShopDbContext _context;

        public PublicProductService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<PageResult<ProductViewModel>> GetAllByCatelogyId(string languageId, GetPublicProductPagingRequest request)
        {
            var query = _context.Products
                .Join(_context.ProductTranslations, p => p.Id, pt => pt.ProductId, (p, pt) => new { p, pt })
                .Join(_context.ProductInCategories, ppt => ppt.p.Id, pic => pic.ProductId, (ppt, pic) => new { ppt, pic })
                .Join(_context.Categories, pptpic => pptpic.pic.CategoryId, c => c.Id, (pptpic, c) => new { pptpic, c })
                .Where(x => x.pptpic.ppt.pt.LanguageId == languageId)
                .Select(x => new { x.pptpic.ppt.p, x.pptpic.ppt.pt, x.pptpic.pic });

            if (request.CategoryId.HasValue == true && request.CategoryId.Value > 0)
            {
                query = query.Where(x => x.pic.CategoryId == request.CategoryId);
            }

            int totalRow = await query.CountAsync();

            var data = await query
                .Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.pt.Name,
                    DateCreated = x.p.DateCreated,
                    Description = x.pt.Description,
                    Details = x.pt.Details,
                    LanguageId = x.pt.LanguageId,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                    SeoAlias = x.pt.SeoAlias,
                    SeoDescription = x.pt.SeoDescription,
                    SeoTitle = x.pt.SeoTitle,
                    Stock = x.p.Stock,
                    ViewCount = x.p.ViewCount
                }).ToListAsync();

            var pageResult = new PageResult<ProductViewModel>()
            {
                TotalRecord = totalRow,
                Items = data
            };

            return pageResult;
        }
    }
}