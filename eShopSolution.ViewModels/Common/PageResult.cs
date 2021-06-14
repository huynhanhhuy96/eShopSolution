namespace eShopSolution.ViewModels.Common
{
    using global::System.Collections.Generic;

    public class PageResult<T>
    {
        public int TotalRecord { get; set; }

        public List<T> Items { get; set; }
    }
}