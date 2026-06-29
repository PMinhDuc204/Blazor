using System.ComponentModel.DataAnnotations;

namespace BlazingInvoices.Models
{
    public class ServiceModel
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public decimal Rate { get; set; }

        [Required, MaxLength(30)]
        public string Unit { get; set; }

        [Required, MaxLength(250)]
        public string Description { get; set; }

        public ServiceModel? Clone() => MemberwiseClone() as ServiceModel;

        internal static IEnumerable<ServiceModel> GetSeedData()
        {
            return new List<ServiceModel>
            {
                new ServiceModel
                {
                    Id = 1,
                    Name = "Website Development",
                    Rate = 5000000,
                    Unit = "Project",
                    Description = "Custom website development using modern technologies."
                },
                new ServiceModel
                {
                    Id = 2,
                    Name = "Mobile App Development",
                    Rate = 8000000,
                    Unit = "Project",
                    Description = "Cross-platform mobile application development."
                },
                new ServiceModel
                {
                    Id = 3,
                    Name = "UI/UX Design",
                    Rate = 1500000,
                    Unit = "Design",
                    Description = "Professional user interface and user experience design."
                },
                new ServiceModel
                {
                    Id = 4,
                    Name = "SEO Optimization",
                    Rate = 1200000,
                    Unit = "Month",
                    Description = "Improve website ranking and search engine visibility."
                },
                new ServiceModel
                {
                    Id = 5,
                    Name = "Cloud Hosting",
                    Rate = 300000,
                    Unit = "Month",
                    Description = "Reliable cloud hosting with automatic backups."
                },
                new ServiceModel
                {
                    Id = 6,
                    Name = "Technical Support",
                    Rate = 200000,
                    Unit = "Hour",
                    Description = "Technical support and troubleshooting services."
                }
            };
        }
    }
}
