using Microsoft.EntityFrameworkCore.Migrations;
using RadRiderWebApp.Models;

#nullable disable

namespace RadRiderWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InsertDataIntoTheSkateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new SkateDbContext();
            context.Skate.AddRange(GetInitialLoadFromSkateTable());
            context.SaveChanges();
        }

        private IList<Skate> GetInitialLoadFromSkateTable()
        {
            return new List<Skate>()
            {
                new Skate
                {
                    Name = "Punk Rocker",
                    Description = "Skate tradicional para manobras urbanas. Perfeito para deslizar nas ruas, com alta durabilidade e estabilidade.",
                    ImagePath = "/img/skate1.jpg",
                    Size = 7.75,
                    SkateModelId = 1,
                    CategoryId = 2,
                    BrandId = 3,
                    ProductReview = 4.2,
                    Amount = 15,
                    Price = 99.99,
                    ManufacturingDate = DateTime.Now.AddMonths(-6)
                },
                new Skate
                {
                    Name = "The Urban Pro",
                    Description = "Ideal para manobras avançadas e competições. Design ergonômico para melhor performance em pistas.",
                    ImagePath = "/img/skate2.jpg",
                    Size = 8.0,
                    SkateModelId = 2,
                    CategoryId = 1,
                    BrandId = 5,
                    ProductReview = 4.5,
                    Amount = 20,
                    Price = 129.99,
                    ManufacturingDate = DateTime.Now
                },
                new Skate
                {
                    Name = "Pink Freud",
                    Description = "Skate ideal para cruzeiros e deslocamentos urbanos. Oferece estabilidade e conforto para longos trajetos.",
                    ImagePath = "/img/skate3.jpg",
                    Size = 8.125,
                    SkateModelId = 3,
                    CategoryId = 3,
                    BrandId = 1,
                    ProductReview = 4.0,
                    Amount = 18,
                    Price = 199.99,
                    ManufacturingDate = DateTime.Now.AddMonths(-7)
                },
                new Skate
                {
                    Name = "Lightning Bolt",
                    Description = "Skate resistente para pistas desafiadoras. Alta performance e durabilidade para manobras radicais.",
                    ImagePath = "/img/skate4.jpg",
                    Size = 8.25,
                    SkateModelId = 4,
                    CategoryId = 2,
                    BrandId = 4,
                    ProductReview = 4.8,
                    Amount = 25,
                    Price = 149.99,
                    ManufacturingDate = DateTime.Now.AddMonths(-4)
                },
                new Skate
                {
                    Name = "The Donut Dream",
                    Description = "Ótima opção para iniciantes nas ruas. Versátil e fácil de manobrar para aprender truques.",
                    ImagePath = "/img/skate5.jpg",
                    Size = 8.5,
                    SkateModelId = 1,
                    CategoryId = 1,
                    BrandId = 2,
                    ProductReview = 4.0,
                    Amount = 22,
                    Price = 79.99,
                    ManufacturingDate = DateTime.Now.AddMonths(-9)
                },
                new Skate
                {
                    Name = "Thunderstorm",
                    Description = "Longboard para velocidade e curvas suaves. Confortável e estável para viagens urbanas.",
                    ImagePath = "/img/skate6.jpg",
                    Size = 8.75,
                    SkateModelId = 2,
                    CategoryId = 3,
                    BrandId = 6,
                    ProductReview = 4.6,
                    Amount = 16,
                    Price = 169.99,
                    ManufacturingDate = DateTime.Now.AddMonths(-2)
                },
                new Skate
                {
                    Name = "FlaSkate",
                    Description = "Estilo retrô para quem curte nostalgia. Design clássico para uma experiência vintage.",
                    ImagePath = "/img/skate7.jpg",
                    Size = 9.0,
                    SkateModelId = 3,
                    CategoryId = 2,
                    BrandId = 7,
                    ProductReview = 4.2,
                    Amount = 19,
                    Price = 299.99,
                    ManufacturingDate = DateTime.Now
                },
                new Skate
                {
                    Name = "Dollar Sign",
                    Description = "Liberdade total para manobras variadas. Ideal para expressar criatividade no skate.",
                    ImagePath = "/img/skate8.jpg",
                    Size = 7.75,
                    SkateModelId = 4,
                    CategoryId = 1,
                    BrandId = 3,
                    ProductReview = 4.4,
                    Amount = 21,
                    Price = 119.99,
                    ManufacturingDate = DateTime.Now.AddMonths(-5)
                },
                new Skate
                {
                    Name = "The Outlaw",
                    Description = "Leve e ágil para deslocamentos urbanos. Ótimo para viagens diárias e passeios descontraídos.",
                    ImagePath = "/img/skate9.jpg",
                    Size = 8.0,
                    SkateModelId = 1,
                    CategoryId = 3,
                    BrandId = 1,
                    ProductReview = 4.0,
                    Amount = 17,
                    Price = 89.99,
                    ManufacturingDate = DateTime.Now.AddMonths(-10)
                },
                new Skate
                {
                    Name = "Warrior",
                    Description = "Inspirado no modelo de um profissional. Alta qualidade para desempenho excepcional.",
                    ImagePath = "/img/skate10.jpg",
                    Size = 8.125,
                    SkateModelId = 2,
                    CategoryId = 2,
                    BrandId = 5,
                    ProductReview = 4.7,
                    Amount = 23,
                    Price = 179.99,
                    ManufacturingDate = DateTime.Now.AddMonths(-1)
                },
                new Skate
                {
                    Name = "Martian",
                    Description = "Estilo vintage para os adeptos do antigo. Design clássico para os amantes do skate retrô.",
                    ImagePath = "/img/skate11.jpg",
                    Size = 8.25,
                    SkateModelId = 3,
                    CategoryId = 1,
                    BrandId = 2,
                    ProductReview = 4.3,
                    Amount = 24,
                    Price = 109.99,
                    ManufacturingDate = DateTime.Now.AddMonths(-11)
                },
                new Skate
                {
                    Name = "Reaper",
                    Description = "Versatilidade e performance para cruzeiros. Ótima opção para quem busca conforto e estilo.",
                    ImagePath = "/img/skate12.jpg",
                    Size = 8.5,
                    SkateModelId = 4,
                    CategoryId = 3,
                    BrandId = 4,
                    ProductReview = 4.5,
                    Amount = 14,
                    Price = 249.99,
                    ManufacturingDate = DateTime.Now.AddMonths(-8)
                }
            };
        }
    }
}
