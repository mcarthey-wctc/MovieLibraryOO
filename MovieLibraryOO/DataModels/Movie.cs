using System;
using System.Collections.Generic;

#nullable disable

namespace MovieLibraryOO.DataModels
{
    public partial class Movie
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public byte[] ReleaseDate { get; set; }
    }
}
