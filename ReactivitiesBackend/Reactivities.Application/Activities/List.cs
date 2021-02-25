using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Domain;
using Reactivities.Persistance;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Reactivities.Application.Activities
{
    public class List
    {
        public class Query : IRequest<IList<Activity>> { }

        public class Handler : IRequestHandler<Query, IList<Activity>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<IList<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Activities.AsNoTracking().ToListAsync();
            }
        }
    }
}
