using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityAPI.Model
{
    public partial class Donation
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Message { get; set; }

        public double Amount { get; set; }
    }
}
