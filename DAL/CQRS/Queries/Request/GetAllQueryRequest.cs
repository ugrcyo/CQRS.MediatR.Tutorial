using DAL.CQRS.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CQRS.Queries.Request
{
    public class GetAllQueryRequest : IRequest<List<GetAllQueryResponse>>
    {
    }
}
