﻿

using publishers.Domain.Core;

namespace publishers.Domain.Entities
{
    public class Stores : BaseEntity
    {
        public string stor_id { get; set; }
        public string? stor_name { get; set; }
        public string? stor_address { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public string? zip {  get; set; }
    }
}
