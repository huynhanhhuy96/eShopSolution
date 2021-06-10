namespace eShopSolution.Application.Catalog.Products.Dtos.Manage
{
    using eShopSolution.Application.Dtos;
    using System.Collections.Generic;

    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CategoryId { get; set; }
    }
}
