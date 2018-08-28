using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyWithMVC5.Models;

namespace VidlyWithMVC5.ViewModel
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

    }
}