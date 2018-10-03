using System;
using System.Collections.Generic;
using System.Text;

namespace ViaExam.Auth.Domain.Entities
{
    public class Authentication
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Sha1 { get; set; }
        public string Salt { get; set; }
    }
}
