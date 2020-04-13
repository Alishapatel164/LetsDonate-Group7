using System;
using System.Configuration;
using DAL;
using DataModels;
using Microsoft.Extensions.Configuration;

namespace Library.BusinessLogic
{
    public class ContactHandler
    {
        private IConfiguration _configuration;

        public ContactHandler() { }
        public ContactHandler(IConfiguration Configuration)
        {
            _configuration = Configuration;

        }

        public GetInTouch1[] GetAllGetInTouch1()
        {
            DataAccess db = new DataAccess(_configuration);

            GetInTouch1[] contacts = db.GetAllGetInTouch1FromDatabase();

            return contacts;
        }

        public object AddGetInTouch1(GetInTouch1 contact1)
        {
            DataAccess db = new DataAccess(_configuration);

            var contacts = db.AddGetInTouch1ToDatabase(contact1);

            return contacts;
        }
        public Donation[] GetAllDonation()
        {
            DataAccess db = new DataAccess(_configuration);

            Donation[] donate = db.GetAllDonationFromDatabase();

            return donate;
        }
        public object AddDonations(Donation donations)
        {
            DataAccess db = new DataAccess(_configuration);

            var donate = db.AddDonationToDatabase(donations);

            return donate;
        }

    }


}

