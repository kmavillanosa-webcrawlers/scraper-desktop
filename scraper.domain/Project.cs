using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scraper.domain
{
    public class Project : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public List<string> OutputColumns { get; set; }
    }
}
