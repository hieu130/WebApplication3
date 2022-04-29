using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Account
    {
        public int Id { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public DateTime DisabledAt { get; set; }
        public string Address { get; set; }
        public string Thumbnail { get; set; }
        public int Status { get; set; }
        public string RoleNumber { get; set; }
        public string EmployeeNumber { get; set; }
        public DateTime AddmissionDate { get; set; }
        public DateTime DateOfJoining { get; set; }
    }
}