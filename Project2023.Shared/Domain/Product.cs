using System;

namespace Project2023.Shared.Domain
{
    public class Product : BaseDomainModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int Rating { get; set; }
    }
}