﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime Timestamp { get; set; }
        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
