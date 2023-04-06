using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = "cac43a6e-f7bb-4448-baaf-ladd413ccbbf",
                UserId = "48aa3a6e-a8bb-4448-baaf-ladd413bcabe"
            },
            new IdentityUserRole<string>
            {
                RoleId = "cac43a7e-f7bb-cc48-baaf-41dd413cc123",
                UserId = "32cc4e6e-a8bb-4448-baaf-ladd413abcfd"
            });
        }
    }
}