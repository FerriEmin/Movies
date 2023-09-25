﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Contracts.Requests
{
    public class UpdateMovieRequest
    {
        public required string Title { get; init; }

        public required string YearOfReleas { get; init; }

        public required IEnumerable<string> Genre { get; init; } = Enumerable.Empty<string>();

    }
}
