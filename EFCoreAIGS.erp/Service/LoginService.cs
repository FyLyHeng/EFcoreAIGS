using EFCoreAIGS.erp.Entites;

namespace EFCoreAIGS.erp.Service
{
    public class LoginService
    {
        private static erpContext repo = new erpContext();
        
        public void Register(User model)
        {
            // hash password
            var passHash = BCrypt.Net.BCrypt.HashPassword(model.Password);
            model.Password = passHash;

            // save account
            repo.Users.Add(model);
            repo.SaveChanges();
        }

        public bool Authenticate(User model)
        {
            // get account from database
            var account = repo.Users.SingleOrDefault(x => x.Username == model.Username);

            // check account found and verify password
            if (account == null || !BCrypt.Net.BCrypt.Verify(model.Password, account.Password))
            {
                // authentication failed
                Console.WriteLine("authentication failed");
            } 
            else
            {
                // authentication successful
                Console.WriteLine("authentication successful");
            }
            
            Console.WriteLine($"UserInput : {model.Password}");
            Console.WriteLine($"FoundPass : {account.Password}");

            return true;
        }
    }
}
