﻿using System;

namespace SugarMama.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string EmailAddress { get; set; }
    }
}
