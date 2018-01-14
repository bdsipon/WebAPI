using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.Core;

namespace Transport.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly TransportContext context;

        public UnitOfWork(TransportContext context)
        {
            this.context = context;
        }
        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
