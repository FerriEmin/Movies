using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Contracts.Requests
{
    public class PagedRequest
    {
        public required int Page { get; init; }

        public required int PageSize { get; init; }
    }
}
