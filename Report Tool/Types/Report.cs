using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Report_Tool
{
    public class Report
    {
        public string ID { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public string WorldId { get; set; }
        public string WorldName { get; set; }
        public string Accuser { get; set; }
        public string Accusee { get; set; }
        public string Reason { get; set; }
        public string[] ChatLog { get; set; }
        public string Handler { get; set; }
        public string ActionTaken { get; set; }
    }
}
