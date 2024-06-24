﻿using CQRS.CORE.Commands;
using CQRS.CORE.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POST.CMD.INFRASTRUCTURE.Dispatchers
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly Dictionary<Type, Func<BaseCommand, Task>> _handlers = new();
        public void RegisterHandler<T>(Func<T, Task> handler) where T : BaseCommand
        {
            throw new NotImplementedException();
        }

        public Task SendAsync(BaseCommand command)
        {
            throw new NotImplementedException();
        }
    }
}