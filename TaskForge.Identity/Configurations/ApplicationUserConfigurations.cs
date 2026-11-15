using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskForge.Identity.Models.Users;

namespace TaskForge.Identity.Configurations;

public class ApplicationUserConfigurations:IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.ToTable("Users");

        builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
        builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
        builder.HasIndex(x=>x.FirstName).HasDatabaseName("IX_FirstName");
        builder.HasIndex(x=>x.LastName).HasDatabaseName("IX_LastName");
        builder.HasIndex(x=> new {x.FirstName, x.LastName}).HasDatabaseName("IX_FirstName_LastName");
    }
}