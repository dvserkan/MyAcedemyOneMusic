using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.BusinessLayer.Validators
{
	public class CustomErrorDescriber : IdentityErrorDescriber
	{
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Description = "Şifre en az 6 karakterden oluşmalıdır."
            };
        }


        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Description = "Şifre en az bir rakam(1-2-3.. ) içermelidir."
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Description = "Şifre en az bir küçük harf (a-z) içermelidir."
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Description = "Şifre en az bir büyük harf (A-Z) içermelidir."
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Description = "Şifre en az bir özel karakter(*,_, -, + ...)  içermelidir."
            };
        }


    }
}
