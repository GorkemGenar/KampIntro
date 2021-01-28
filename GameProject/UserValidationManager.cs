using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "Görkem" && gamer.BirthYear == 1991 && gamer.LastName == "Akkaya" && gamer.IdentityNumber == 1231233123)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
