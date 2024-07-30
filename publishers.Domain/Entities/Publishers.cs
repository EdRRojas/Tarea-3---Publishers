
using publishers.Domain.Core;

namespace publishers.Domain.Entities
{
    public class Publishers : BaseEntity
    {
        public string pub_id { get; set; }
        public string? pub_name { get; set;}
        public string? city { get; set; }
        public string? state { get; set; }
        public string? country { get; set; }        
    }
}
