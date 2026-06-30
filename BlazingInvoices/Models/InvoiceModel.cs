namespace BlazingInvoices.Models
{
    public class InvoiceModel
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public DateTime IssuedOn { get; set; }
        public DateTime? DueOn { get; set; }
        public bool IsPaid { get; set; }
        public DateTime? PaidOn { get; set; }
        public string Status => IsPaid ? "Paid" : "Pending";
        public IEnumerable<InvoiceLineModel> LineItems { get; set; } = [];
        public decimal TotalAmount => LineItems.Sum(l => l.Amount);
    }

    public class InvoiceLineModel
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public decimal Rate { get; set; }
        public string Unit {  get; set; }
        public int Quantity { get; set; }
        public decimal Amount => Rate * Quantity;
    }

    public static class InvoiceSeeder
    {
        public static IEnumerable<InvoiceModel> GetInvoiceModels()
        {
            return new List<InvoiceModel>
            {
                new InvoiceModel
                {
                    Id = 1,
                    InvoiceNumber = "INV-2025-001",
                    ClientId = 1,
                    ClientName = "TechNava Solutions",
                    IssuedOn = new DateTime(2025, 1, 15),
                    DueOn = new DateTime(2025, 2, 14),
                    IsPaid = true,
                    PaidOn = new DateTime(2025, 2, 10),
                    LineItems =
                    [
                        new() { ServiceId = 1, ServiceName = "Website Development", Rate = 5_000_000, Unit = "Project", Quantity = 1 },
                        new() { ServiceId = 4, ServiceName = "SEO Optimization", Rate = 1_200_000, Unit = "Month", Quantity = 3 },
                    ],
                },
                new()
                {
                    Id = 2,
                    InvoiceNumber = "INV-2025-002",
                    ClientId = 2,
                    ClientName = "BlueSky Digital",
                    IssuedOn = new DateTime(2025, 2, 1),
                    DueOn = new DateTime(2025, 3, 1),
                    IsPaid = false,
                    LineItems =
                    [
                        new() { ServiceId = 2, ServiceName = "Mobile App Development", Rate = 8_000_000, Unit = "Project", Quantity = 1 },
                        new() { ServiceId = 6, ServiceName = "Technical Support", Rate = 200_000, Unit = "Hour", Quantity = 20 },
                    ],
                },
                new()
                {
                    Id = 3,
                    InvoiceNumber = "INV-2025-003",
                    ClientId = 1,
                    ClientName = "TechNava Solutions",
                    IssuedOn = new DateTime(2025, 3, 10),
                    DueOn = new DateTime(2025, 4, 9),
                    IsPaid = true,
                    PaidOn = new DateTime(2025, 3, 28),
                    LineItems =
                    [
                        new() { ServiceId = 3, ServiceName = "UI/UX Design", Rate = 1_500_000, Unit = "Design", Quantity = 2 },
                        new() { ServiceId = 5, ServiceName = "Cloud Hosting", Rate = 300_000, Unit = "Month", Quantity = 6 },
                    ],
                },
                new()
                {
                    Id = 4,
                    InvoiceNumber = "INV-2025-004",
                    ClientId = 2,
                    ClientName = "BlueSky Digital",
                    IssuedOn = new DateTime(2025, 4, 5),
                    DueOn = new DateTime(2025, 5, 5),
                    IsPaid = false,
                    LineItems =
                    [
                        new() { ServiceId = 1, ServiceName = "Website Development", Rate = 5_000_000, Unit = "Project", Quantity = 1 },
                        new() { ServiceId = 4, ServiceName = "SEO Optimization", Rate = 1_200_000, Unit = "Month", Quantity = 6 },
                        new() { ServiceId = 5, ServiceName = "Cloud Hosting", Rate = 300_000, Unit = "Month", Quantity = 12 },
                    ],
                },
                new()
                {
                    Id = 5,
                    InvoiceNumber = "INV-2025-005",
                    ClientId = 1,
                    ClientName = "TechNava Solutions",
                    IssuedOn = new DateTime(2025, 5, 20),
                    DueOn = new DateTime(2025, 6, 19),
                    IsPaid = true,
                    PaidOn = new DateTime(2025, 6, 15),
                    LineItems =
                    [
                        new() { ServiceId = 6, ServiceName = "Technical Support", Rate = 200_000, Unit = "Hour", Quantity = 40 },
                    ],
                },
            };
        }
    }
}
