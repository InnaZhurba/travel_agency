﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class TourType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public virtual Tour Tour { get; set; }
    }
}
