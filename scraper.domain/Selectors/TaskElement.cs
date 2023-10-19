using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scraper.domain
{
    //find elements, if !multiple set elements.first()
    public abstract class TaskElement<TValue>
    {
        public TValue Value { get; set; }
        public bool IsMultiple { get; set; } = false;

    }
}
