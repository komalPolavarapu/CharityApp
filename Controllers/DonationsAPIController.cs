using CharityAPI.Data;
using CharityAPI.Interfaces;
using CharityAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CharityAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DonationsAPIController : ControllerBase,IDonation
    {
        private readonly CharityAPIContext _context;

        public DonationsAPIController(CharityAPIContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<List<Donation>> GetDonations()
        {
            return  _context.Donation.ToList();
        }

        [HttpPost]
        public async Task<int> AddDonation(Donation donation)
        {
            _context.Donation.Add(donation);
            //int donationId = await _context.SaveChangesAsync();
          

            return 0;
        }
    }
}
