using System;
using System.Collections.Generic;

#nullable disable

namespace MovieLibraryOO.DataModels
{
    public partial class Rating
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public long? MovieId { get; set; }
        public long? Rating1 { get; set; }
        public byte[] RatedAt { get; set; }
    }
}
