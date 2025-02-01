using Mailoo.Data.Enums;

namespace Mailoo.Models
{
    public class Delivery
    {
        public int Id { get; set; }
        public Governorate Name { get; set; }
        public double DeliveryFee { get; set; }
    }
}
