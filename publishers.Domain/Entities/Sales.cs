﻿
using publishers.Domain.Core;

namespace publishers.Domain.Entities
{
    public class Sales : BaseEntity
    {
        public string stor_id { get; set; }
        public string ord_num { get; set; }
        public DateTime ord_date { get; set; }
        public int qty { get; set; }
        public string payterms { get; set; }
        public string title_id { get; set; }
    }
}
