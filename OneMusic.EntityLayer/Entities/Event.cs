﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.EntityLayer.Entities
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string place { get; set; }
        public string ImageUrl { get; set; }
        public string Datetime { get; set; }
        public bool Status { get; set; } = true;
    }
}
