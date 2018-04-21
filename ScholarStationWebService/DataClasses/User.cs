﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DataClasses
{
    public class User : IUser
    {
        private string userID;
        private string bio;
        private string university;
        private string email;
        private UserType uType;
        private bool verified;

        public string UserID
        {
            get { return this.userID != null ? this.userID : "Null"; }
            set { this.userID = value; }
        }

        public string Bio
        {
            get { return this.bio != null ? this.bio : "Null"; }
            set { this.bio = value; }
        }

        public UserType UType
        {
            get; set;
        }

        public bool Verified
        {
            get; set;
        }
        public string University
        {
            get { return this.university != null ? this.university : "Null"; }
            set { this.university = value; }
        }

        public string Email
        {
            get { return this.email!= null ? this.email : "Null"; }
            set { this.email = value; }
        }

        public bool isNull()//Test this extensively
        {
            return (UserID.Equals("Null") && Bio.Equals("Null") &&  University.Equals("Null"));
        }
    }
}
