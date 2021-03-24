using System;
using System.Collections.Generic;

#nullable disable

namespace MovieLibraryOO.DataModels
{
    public partial class User
    {
        public long Id { get; set; }
        public long? Age { get; set; }
        public string Gender { get; set; }
        public long? OccupationId { get; set; }
        public string ZipCode { get; set; }
    }
}
