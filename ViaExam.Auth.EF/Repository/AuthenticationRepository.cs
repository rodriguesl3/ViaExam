using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViaExam.Auth.Domain.Entities;
using ViaExam.Auth.EF.Context;

namespace ViaExam.Auth.EF.Repository
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly EfDbContext _context;

        public AuthenticationRepository(EfDbContext context)
        {
            _context = context;
        }

        public Authentication GetUser(Authentication authentication)
        {
            var auth = _context.Authentication.FirstOrDefault(x => x.Email == authentication.Email);

            return auth;
        }

        public Authentication SetUser(Authentication authentication)
        {
            _context.Authentication.Add(authentication);
            _context.SaveChanges();

            return authentication;
        }
    }
}
