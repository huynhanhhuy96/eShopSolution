namespace eShopSolution.Application.Catalog.Products
{
    using eShopSolution.Application.Catalog.Products.Dtos;
    using eShopSolution.Application.Catalog.Products.Dtos.Manage;
    using eShopSolution.Application.Dtos;
    using eShopSolution.Data.EF;
    using eShopSolution.Data.Entities;
    using eShopSolution.Utilities.Exceptions;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    class ManageProductService : IManageProductService
    {
        private readonly EShopDbContext _context;

        public ManageProductService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task AddViewCount(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            product.ViewCount += 1;

            await _context.SaveChangesAsync();
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
                OriginalPrice = request.OriginalPrice,
                Stock = request.Stock,
                ViewCount = 0,
                DateCreated = DateTime.Now,
                ProductTranslations = new List<ProductTranslation>()
                {
                    new ProductTranslation()
                    {
                        Name = request.Name,
                        Description = request.Description,
                        Details = request.Details,
                        SeoDescription = request.SeoDescription,
                        SeoAlias = request.SeoAlias,
                        SeoTitle = request.SeoTitle,
                        LanguageId = request.LanguageId
                    }
                }
            };

            _context.Products.Add(product);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);

            if (product == null)
            {
                throw new EShopException($"Cannot find a product: {productId}");
            }

            _context.Products.Remove(product);

            return await _context.SaveChangesAsync();
        }

        public Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PageResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        {
            var query = _context.Products
                .Join(_context.ProductTranslations, p => p.Id, pt => pt.ProductId, (p, pt) => new { p, pt })
                .Join(_context.ProductInCategories, ppt => ppt.p.Id, pic => pic.ProductId, (ppt, pic) => new { ppt, pic })
                .Join(_context.Categories, pptpic => pptpic.pic.CategoryId, c => c.Id, (pptpic, c) => new { pptpic, c })
                .Select(x => new { x.pptpic.ppt.p, x.pptpic.ppt.pt, x.pptpic.pic });

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.pt.Name.Contains(request.Keyword));
            }

            if (request.CategoryId.Count > 0)
            {
                query = query.Where(x => request.CategoryId.Contains(x.pic.CategoryId));
            }

            int totalRow = await query.CountAsync();

            var data = await query
                .Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x=> new ProductViewModel()
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

        public async Task<int> Update(ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStock(int productId, int addQuantity)
        {
            throw new NotImplementedException();
        }
    }
}
