using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Report_Tool
{
    public class Ban
    {
        public string ID { get; set; }
        public string Reason { get; set; }
        public string BannedBy { get; set; }
        public DateTime BanDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
