using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "Görkem",
                LastName = "Akkaya",
                BirthYear = 1991,
                IdentityNumber = 1231233123
            });

            Console.ReadLine();
        }
    }
}
