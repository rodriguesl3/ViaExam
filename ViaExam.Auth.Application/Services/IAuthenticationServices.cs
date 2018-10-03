using System;
using System.Collections.Generic;
using System.Text;
using ViaExam.Auth.Domain.Entities;

namespace ViaExam.Auth.Application.Services
{
    public interface IAuthenticationServices
    {
        Authentication GetUser(Authentication authentication);
        Authentication SetUser(Authentication authentication);

    }
}
