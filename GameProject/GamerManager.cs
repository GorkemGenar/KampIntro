using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName + " kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Doğrulama ve kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " güncellendi");
        }
    }
}
