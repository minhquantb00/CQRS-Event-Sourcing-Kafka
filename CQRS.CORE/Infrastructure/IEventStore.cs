﻿using CQRS.CORE.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.CORE.Infrastructure
{
    public interface IEventStore
    {
        Task SaveEventAsync(Guid aggregateId, IEnumerable<BaseEvent> events, int expectedVersion);
        Task<List<BaseEvent>> GetEventsAsync(Guid aggregateId);
    }
}
