using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scraper.domain
{

    public enum ProjectTaskType
    {
        GetOne, GetMany, Execute, Hover, Extract
    }

    public class ProjectTask : EntityBase
    {
        public int Sequence { get; set; }

        public ProjectTaskType TaskType { get; set; }


    }
}
