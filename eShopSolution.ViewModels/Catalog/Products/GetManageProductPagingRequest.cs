namespace eShopSolution.ViewModels.Catalog.Products
{
    using eShopSolution.ViewModels.Common;
    using System.Collections.Generic;

    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CategoryId { get; set; }
    }
}
