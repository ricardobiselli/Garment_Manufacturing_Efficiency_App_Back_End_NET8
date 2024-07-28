using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Users
{
    public abstract class User
    {
        public User() { }
        public User(string usertype, string username, EmailAddressAttribute emailaddress, string password) 
        { 
            UserType = usertype;
            UserName = username;
            EmailAddress = emailaddress;
            Password = password;
        }

        public int Id { get; set; }
        public string UserType { get; set; }
        public string UserName { get; set; }
        public EmailAddressAttribute EmailAddress { get; set; }
        public string Password { get; set; }
        

    }
}
