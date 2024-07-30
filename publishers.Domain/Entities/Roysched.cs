
using publishers.Domain.Core;

namespace publishers.Domain.Entities
{
    public class Roysched : BaseEntity
    {
        public string title_id { get; set; }
        public int? lorange {  get; set; }
        public int? hirange { get; set; }
        public int? royalty { get; set; }
    }
}
