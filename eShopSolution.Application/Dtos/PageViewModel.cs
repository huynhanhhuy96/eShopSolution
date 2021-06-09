using System.Collections.Generic;

namespace eShopSolution.Application.Dtos
{
    public class PageViewModel<T>
    {
        public int TotalProduct { get; set; }

        public List<T> Items { get; set; }
    }
}
