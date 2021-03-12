using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyManagement.UI.Data
{
    public class PolicyRequestModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string RegistrationNumber { get; set; }

        public string CarModel { get; set; }
        public string CardMake { get; set; }

        public string Premium { get; set; }
        public string PremType { get; set; }
    }
}
