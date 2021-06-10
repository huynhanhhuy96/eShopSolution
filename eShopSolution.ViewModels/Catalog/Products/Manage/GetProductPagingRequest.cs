namespace eShopSolution.ViewModels.Catalog.Products.Manage
{
    using eShopSolution.ViewModels.Common;
    using System.Collections.Generic;

    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CategoryId { get; set; }
    }
}
