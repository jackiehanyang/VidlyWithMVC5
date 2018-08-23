using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyWithMVC5.Models
{
    public class Movie
    {
        // represent the state and behavior of our application in terms of its problem domain
        // in this case, it doesn't have any behavior or logic, only couple properties which we used for representing state
        public int Id { get; set; }
        public string Name { get; set; }
    }
}