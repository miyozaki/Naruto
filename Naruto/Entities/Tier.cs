using System;

namespace Naruto.Entities
{
    public class Tier
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual Shinobi Shinobi { get; set; }
    }
}