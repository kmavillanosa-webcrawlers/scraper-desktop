﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scraper.domain
{
    public abstract class EntityBase
    {
        [Key]
        public byte[] Id { get; set; }


    }
}
