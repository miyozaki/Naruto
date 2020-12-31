using System;
using System.Collections.Generic;

namespace Naruto.Entities
{
    public class Shinobi
    {
        public Guid Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string ProfileImage { get; set; }
        public string CoverImage { get; set; }
        public virtual ICollection<Tier> Tiers { get; set; }
    }
}