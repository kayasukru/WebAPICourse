using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee()
                {
                    Id = new Guid("2fbfe11d-b744-4269-83d7-dd0b5b23e941"),
                    ProjectId = new Guid("1752e9e5-de76-49f5-b27e-eca83eb6685a"),
                    FirstName= "Şükrü",
                    LastName="Kaya",
                    Age=57,
                    Position = "Senior Develpoer"
                });
        }
    }
}
