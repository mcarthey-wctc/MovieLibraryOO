using System;
using System.Collections.Generic;

#nullable disable

namespace MovieLibraryOO.DataModels
{
    public partial class GenresMovie
    {
        public long Id { get; set; }
        public long? MovieId { get; set; }
        public long? GenreId { get; set; }
    }
}
