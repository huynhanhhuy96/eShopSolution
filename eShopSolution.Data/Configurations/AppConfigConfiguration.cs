﻿namespace eShopSolution.Data.Configurations
{
    using eShopSolution.Data.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfigs");
            builder.HasKey(x=>x.Key);
            builder.Property(x => x.Value).IsRequired(true);
        }
    }
}
