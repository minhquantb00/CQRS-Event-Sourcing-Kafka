﻿using CQRS.CORE.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POST.COMMONS.Events
{
    public class CommentUpdatedEvent : BaseEvent
    {
        public CommentUpdatedEvent() : base(nameof(CommentUpdatedEvent)) { }
        public Guid CommentId { get; set; }
        public string Comment {  get; set; }
        public string Username { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
