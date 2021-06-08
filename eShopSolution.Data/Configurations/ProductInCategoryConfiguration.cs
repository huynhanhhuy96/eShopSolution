﻿namespace eShopSolution.Data.Configurations
{
    using eShopSolution.Data.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");

            builder.HasKey(x => new { x.CategoryId, x.ProductId });

            builder.HasOne(x => x.Product).WithMany(x => x.ProductInCategories)
                .HasForeignKey(x=>x.ProductId);

            builder.HasOne(x => x.Category).WithMany(x => x.ProductInCategories)
                .HasForeignKey(x=>x.CategoryId);
        }
    }
}
