using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DALSprint1;
namespace BusinessLayerSprint1
{
    public class Admin
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public static bool isValidAdmin(string username ,string password)
        {
            bool status = AdminData.CheckAuthentication(username,password);

            return status;
        }
        
        public static Admin FetchAdminDetals()
        {
            List<string> adminDetails = AdminData.SendAdminDetails();
            Admin objAdmin = new Admin
            {
                Name = adminDetails[0],
                DOB = Convert.ToDateTime(adminDetails[0])
            };
            return objAdmin;
            
        }
    }
}
