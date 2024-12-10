using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mia_OWP_FINALNI.Models;

namespace Mia_OWP_FINALNI.ViewModels
{
    public class newCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}