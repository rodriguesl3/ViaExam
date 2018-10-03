using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using ViaExam.Auth.Application.Util;
using ViaExam.Auth.Domain.Entities;
using ViaExam.Auth.EF.Repository;

namespace ViaExam.Auth.Application.Services
{
    public class AuthenticationServices : IAuthenticationServices
    {

        private readonly IAuthenticationRepository _authRepository;

        public AuthenticationServices(IAuthenticationRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public Authentication GetUser(Authentication authentication)
        {
            var user = _authRepository.GetUser(authentication);
            var tempPwd = $"{authentication.Password}{user.Salt}";
            var encode = CryptoUtil.EncryptSHA1(tempPwd);
            return user.Sha1 == encode ? user : null;
        }

        public Authentication SetUser(Authentication authentication)
        {
            authentication.Sha1 = CryptoUtil.EncryptSHA1($"{authentication.Password}{authentication.Salt}");
            return _authRepository.SetUser(authentication);
        }
    }
}
