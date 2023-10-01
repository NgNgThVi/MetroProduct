using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetroDelivery.Identity.Configurations.EntityConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryID = Guid.Parse("175D4C8D-D2F0-441B-85CB-45A1CB0B6756"),
                    ProductName = "Keo bông gòn",
                    Image = null,
                    ProductDescription = "Kẹo thơm ngon được tạo ra từ các loại đường, được làm nóng và tạo nên hương vị ngọt ngào",
                    Stock = 300,
                    Price = 5000.500
                },
                new Product

                {
                    Id = Guid.NewGuid(),
                    CategoryID = Guid.Parse("175D4C8D-D2F0-441B-85CB-45A1CB0B6756"),
                    ProductName = "Kẹo lạc",
                    Image = null,
                    ProductDescription = "Kẹo lạc thơm ngon, giòn tan",
                    Stock = 200,
                    Price = 3000
                },
                new Product

                {
                    Id = Guid.NewGuid(),
                    CategoryID = Guid.Parse("175D4C8D-D2F0-441B-85CB-45A1CB0B6756"),
                    ProductName = "Kẹo chup",
                    Image = null,
                    ProductDescription = "Kẹo lạc thơm ngon, giòn tan",
                    Stock = 200,
                    Price = 3000
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryID = Guid.Parse("8908EA98-B421-420B-9634-03ED356BB921"),
                    ProductName = "Khoai tây chiên",
                    Image = null,
                    ProductDescription = "Khoai tây chiên giòn tan",
                    Stock = 500,
                    Price = 10000
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryID = Guid.Parse("175D4C8D-D2F0-441B-85CB-45A1CB0B6756"),
                    ProductName = "Kẹo dẻo",
                    Image = null,
                    ProductDescription = "Kẹo dẻo mềm, đàn hồi",
                    Stock = 500,
                    Price = 2500

                }, new Product
                {
                    Id = Guid.NewGuid(),

                    CategoryID = Guid.Parse("9AFCDFAC-1A27-496B-84E5-0C8E5804E40E"),
                    ProductName = "Cơm gà xé",
                    Image = null,
                    ProductDescription = "Cơm gà xé thơm ngon",
                    Stock = 200,
                    Price = 30000
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryID = Guid.Parse("9B2CCCB2-F5FA-4358-8265-0FE4F7A52253"),
                    ProductName = "Bánh quy giòn",
                    Image = null,
                    ProductDescription = "Bánh quy giòn tan trong miệng",
                    Stock = 1000,
                    Price = 5000
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryID = Guid.Parse("175D4C8D-D2F0-441B-85CB-45A1CB0B6756"),
                    ProductName = "Kẹo Socola",
                    Image = null,
                    ProductDescription = "Kẹo sô cô la ngọt thanh",
                    Stock = 1000,
                    Price = 10000

                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryID = Guid.Parse("175D4C8D-D2F0-441B-85CB-45A1CB0B6756"),
                    ProductName = "Kẹo dâu",
                    Image = null,
                    ProductDescription = "Kẹo dâu tây thơm ngon",
                    Stock = 800,
                    Price = 15000
                },
                new Product

                {
                    Id = Guid.NewGuid(),
                    CategoryID = Guid.Parse("9AFCDFAC-1A27-496B-84E5-0C8E5804E40E"),
                    ProductName = "Gà rán",
                    Image = null,
                    ProductDescription = "Gà rán giòn tan thơm ngon",
                    Stock = 500,
                    Price = 50000
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryID = Guid.Parse("9AFCDFAC-1A27-496B-84E5-0C8E5804E40E"),
                    ProductName = "Cá chiên",
                    Image = null,
                    ProductDescription = "Cá chiên giòn rụm",
                    Stock = 300,
                    Price = 65000

                },
                new Product

                {
                    Id = Guid.NewGuid(),
                    CategoryID = Guid.Parse("175D4C8D-D2F0-441B-85CB-45A1CB0B6756"),
                    ProductName = "Kẹo bạc hà",
                    Image = null,
                    ProductDescription = "Kẹo bạc hà mát lạnh",
                    Stock = 1200,
                    Price = 5000
                },
                new Product

                {
                    Id = Guid.NewGuid(),
                    CategoryID = Guid.Parse("175D4C8D-D2F0-441B-85CB-45A1CB0B6756"),
                    ProductName = "Kẹo mút",
                    Image = null,
                    ProductDescription = "Kẹo mút mềm dẻo",
                    Stock = 2000,
                    Price = 2500

                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryID = Guid.Parse("9AFCDFAC-1A27-496B-84E5-0C8E5804E40E"),
                    ProductName = "Gà nướng",
                    Image = null,
                    ProductDescription = "Gà nướng thơm phức",
                    Stock = 800,
                    Price = 80000
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CategoryID = Guid.Parse("9AFCDFAC-1A27-496B-84E5-0C8E5804E40E"),
                    ProductName = "Cơm chiên dương châu",
                    Image = null,
                    ProductDescription = "Cơm chiên dương châu thơm ngon",
                    Stock = 1000,
                    Price = 25000
                }
                );
        }
    }


}
