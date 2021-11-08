using CharityAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DonationController : ControllerBase
    {        
        public List<Donation> donations = new List<Donation>() { new Donation() { Id = 1, Name = "komal", Message = "Donation1", Amount = 100 }, new Donation() { Id = 2, Name = "Krishna", Message = "Donation2", Amount = 200 }
    };

    private readonly ILogger<DonationController> _logger;

        public DonationController(ILogger<DonationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Donation> GetDonations()
        {
            return donations;
        }

       [HttpPost]
       public List<Donation> AddDonation(Donation donation)
        {
             donations.Add(donation);

            return donations;
        }
    }
}
