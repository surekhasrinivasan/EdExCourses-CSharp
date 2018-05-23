using System;

namespace Mod2_AnonymousClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Anon Class

            var anon = new { Name = "Gerry", Age = 29 };

            var anon2 = new { Name = "Tom", Age = 65 };

            Console.WriteLine(anon.Name + " " + anon.Age);
            Console.WriteLine(anon2.Name + " " + anon2.Age);

            #endregion
        }
    }
}
