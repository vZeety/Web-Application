using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using System.Net;
using Resume.Models;

namespace Resume.Models
{
    public class DBGateway
    {
        private readonly string connectionString;
        private IConfiguration configuration;
        public DBGateway(IConfiguration iconfig)
        {
            this.configuration = iconfig;
            this.connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnection");
        }

        public string ConnectionString
        {
            get { return connectionString; }
        }

        public List<Info> GetInfo()
        {
            // this is my sql statement
            string sql = "select myid, name, adress, phonenumber, mail, introduction,inactive,eduid,skillid,experienceid from info;";

            List<Info> info;

            // This connects to the database
            using (var connection = new SqlConnection(ConnectionString))
            {

                // Use the Query method to execute the query and return a list of objects    
                info = connection.Query<Info>(sql).ToList();
            }

            // For some reason the above code sets IsDirty to true, not sure why
            // I reset it to false
            foreach (var c in info) { c.IsDirty = false; }


            // this sends the results back to my Controller
            return info;
        }

        public List<Education> GetEducation()
        {
            // this is my sql statement
            string sql = "select eduid, description, date, major, minor from Education;";
            List<Education> education;

            // This connects to the database
            using (var connection = new SqlConnection(ConnectionString))
            {

                // Use the Query method to execute the query and return a list of objects    
                education = connection.Query<Education>(sql).ToList();
            }

            // For some reason the above code sets IsDirty to true, not sure why
            // I reset it to false
            foreach (var c in education) { c.IsDirty = false; }


            // this sends the results back to my Controller
            return education;
        }

        public List<Skills> GetSkills()
        {
            // this is my sql statement
            string sql = "select skillid, skillname, description from Skills;";
            List<Skills> skills;

            // This connects to the database
            using (var connection = new SqlConnection(ConnectionString))
            {

                // Use the Query method to execute the query and return a list of objects    
                skills = connection.Query<Skills>(sql).ToList();
            }

            // For some reason the above code sets IsDirty to true, not sure why
            // I reset it to false
            foreach (var c in skills) { c.IsDirty = false; }


            // this sends the results back to my Controller
            return skills;
        }

        public List<Experience> GetExperience()
        {
            // this is my sql statement
            string sql = "select experienceid, companyname, startdate,enddate,description from Experience;";
            List<Experience> experience;

            // This connects to the database
            using (var connection = new SqlConnection(ConnectionString))
            {

                // Use the Query method to execute the query and return a list of objects    
                experience = connection.Query<Experience>(sql).ToList();
            }

            // For some reason the above code sets IsDirty to true, not sure why
            // I reset it to false
            foreach (var c in experience) { c.IsDirty = false; }


            // this sends the results back to my Controller
            return experience;
        }
    }
}