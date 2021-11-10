using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Post { get; set; }
     
        public string JoiningDate { get; set; }
        public double Salary { get; set; }
    
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
