using System.ComponentModel.DataAnnotations;

namespace BlazingInvoices.Models
{
    public class ClientModel
    {
        public int Id { get; set; }

        [Required, MaxLength]
        public string Name {  get; set; }

        [Required, EmailAddress, MaxLength(120)]
        public string Email { get; set; }

        [Required, MaxLength(15)]
        public string ContactNumber { get; set; }

        [MaxLength(250)]
        public string? Remarks { get; set; }
        public ClientModel? Clone() => MemberwiseClone() as ClientModel;
        public static IEnumerable<ClientModel> GetSeedData()
        {
            return new List<ClientModel>
            {
                new ClientModel
                {
                    Id = 1,
                    Name = "TechNava Solutions",
                    Email = "admin1@gmail.com",
                    ContactNumber = "0987654321",
                    Remarks = "Website development and annual maintenance client",
                },
                new ClientModel
                {
                    Id = 1,
                    Name = "BlueSky Digital",
                    Email = "admin1@gmail.com",
                    ContactNumber = "0987654321",
                    Remarks = "Website development and annual maintenance client",
                },
            };
        }
    }
}
