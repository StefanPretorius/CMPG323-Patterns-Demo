﻿using System;
using System.Collections.Generic;

namespace HomeWork_Patterns.Models
{
    public partial class Service
    {
        public Guid ServiceId { get; set; }
        public string? ServiceName { get; set; }
        public string? ServiceDescription { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
