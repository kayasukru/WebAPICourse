using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Config
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasData(
                new Project
                {
                    Id = new Guid("1752e9e5-de76-49f5-b27e-eca83eb6685a"),
                    Name = "ASP.NET Core Web API Project",
                    Description = "Web Uygulama Arayüzü Programlama",
                    Field = "Computer Science"
                });
        }
    }
}
