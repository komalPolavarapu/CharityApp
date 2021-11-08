using CharityAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityAPI.Interfaces
{
    public interface IDonation
    {

        public Task<List<Donation>> GetDonations();

        public Task<int> AddDonation(Donation donation);

        
    }
}
