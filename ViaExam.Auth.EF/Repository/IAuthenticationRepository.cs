using System;
using System.Collections.Generic;
using System.Text;
using ViaExam.Auth.Domain.Entities;

namespace ViaExam.Auth.EF.Repository
{
    public interface IAuthenticationRepository
    {
        Authentication GetUser(Authentication authentication);
        Authentication SetUser(Authentication authentication);
    }
}
