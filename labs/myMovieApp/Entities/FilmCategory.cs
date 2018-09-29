using System;
using System.Collections.Generic;

namespace myMovieApp.Entities
{
    public partial class FilmCategory
    {
        public int FilmId { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public Film Film { get; set; }
    }
}
