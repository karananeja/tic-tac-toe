using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Models
{
    
    public class CDetails
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Confirm_Password { get; set; }
        public string Phone_No { get; set; }
        public DateTime DateofBirth { get; set; }
    }
}