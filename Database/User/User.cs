﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.User
{
    public class User
    {
        public  int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public double Phones { get; set; }
        public string UserName { get; set; }
        public string password { get; set; }
        public DateTime RegisteryDate { get; set; }

        //public static int GetUserName(int Id)
        //{
            
        //    return Id;
                
        //} 

    }
}
