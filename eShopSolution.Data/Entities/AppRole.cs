namespace eShopSolution.Data.Entities
{
    using Microsoft.AspNetCore.Identity;
    using System;

    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
