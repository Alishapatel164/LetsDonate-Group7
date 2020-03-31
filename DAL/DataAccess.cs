using Microsoft.Extensions.Configuration;
using System.Data;
using Dapper;
using System;
using System.Linq;
using DataModels;
using System.Data.SqlClient;
using System.Configuration;


namespace DAL
{
    public class DataAccess
    {

        private readonly string ConnectionStringName = "DefaultConnection";
        private IConfiguration _configuration;

        public DataAccess() { }
        public DataAccess(IConfiguration Configuration)
        {
            _configuration = Configuration;
        }
        public GetInTouch1[] GetAllGetInTouch1FromDatabase()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.BlogConnectionStringValue(_configuration, ConnectionStringName)))
            {

                GetInTouch1[] contacts = connection.Query<GetInTouch1>("Select * from GetInTouch order by id asc").ToArray();
                return contacts;
            }
           
        }
        public object AddGetInTouch1ToDatabase(GetInTouch1 newGetInTouch1)
        {
            string queryString = "INSERT INTO GetInTouch(Name,Email,Contact,Message,DateCreated)Values('" + newGetInTouch1.Name + "','" + newGetInTouch1.Email + "','" + newGetInTouch1.Contact + "','" + newGetInTouch1.Message + "','" + newGetInTouch1.DateCreated + "');";
            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.BlogConnectionStringValue(_configuration, ConnectionStringName)))
            {

                GetInTouch1[] contacts = connection.Query<GetInTouch1>(queryString).ToArray();
                return contacts;
            }
        }
        public object AddDonationToDatabase(Donation newDonation)
        {
            string queryString = "INSERT INTO Donate(Organization,Donar_name,Address,Contact_no,Email_id,Amount)Values('" + newDonation.Organization + "','" + newDonation.Name + "','" + newDonation.Address + "','" + newDonation.Contact_No + "','" + newDonation.Email + "'," + newDonation.Amount + ");";

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.BlogConnectionStringValue(_configuration, ConnectionStringName)))
            {

                Donation[] donate = connection.Query<Donation>(queryString).ToArray();
                return donate;
            }
        }

    }
}

