using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PolicyManagementApi.Models
{
  public  class Policy
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
