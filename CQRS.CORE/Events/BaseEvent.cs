﻿using CQRS.CORE.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.CORE.Events
{
    public abstract class BaseEvent : Message
    {
        protected BaseEvent(string type) 
        {
            this.Type = type;
        }
        public int Version { get; set; }
        public string Type { get; set; }
    }
}
