using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyWithMVC5.Models
{
    public class MembershipType
    {
        // In EF, every entity must have a key, which will be mapped to the primary key
        // of the corresponding table in the database.
        // By convention, this should be called either ID, or nameID
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public string Name { get; set; }
    }
}