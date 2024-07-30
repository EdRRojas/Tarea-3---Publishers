
using publishers.Domain.Core;

namespace publishers.Domain.Entities
{
    public class Pub_info : BaseEntity
    {
        public string pub_id { get; set; }
        public byte[]? logo { get; set; }
        public string? pr_info { get; set; }
    }
}
