using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CharityAPI.Model;

namespace CharityAPI.Data
{
    public class CharityAPIContext : DbContext
    {     

        public CharityAPIContext()
        {
            Donation = new List<Donation>() { new Donation() { Id = 1, Name = "komal", Message = "Donation1", Amount = 100 }, new Donation() { Id = 2, Name = "Krishna", Message = "Donation2", Amount = 200 } };
            //Donation.Add(new Donation() { Id = 1, Name = "komal", Message = "Donation1", Amount = 100 });

            //Donation.Add(new Donation() { Id = 2, Name = "Krishna", Message = "Donation2", Amount = 200 });

        }

        public List<CharityAPI.Model.Donation> Donation { get; set; }
    }
}
