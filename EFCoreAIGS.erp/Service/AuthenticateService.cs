using EFCoreAIGS.erp.Entites;

namespace EFCoreAIGS.erp.Service
{
    public class AuthenticateService
    {
        private static erpContext repo = new erpContext();
        private string _currentUserLogin = String.Empty;
        
        public void Register(User model)
        {
            var passHash = BCrypt.Net.BCrypt.HashPassword(model.Password);
            model.Password = passHash;

            repo.Users.Add(model);
            repo.SaveChanges();
        }

        public bool Login(User model)
        {
            var account = repo.Users.SingleOrDefault(x => x.Username == model.Username);
            if (account == null || !BCrypt.Net.BCrypt.Verify(model.Password, account.Password))
            {
                Console.WriteLine("authentication failed");
                return false;
            }
            
            Console.WriteLine("authentication successful");
            _currentUserLogin = account.Username!;
            return true;
        }
        
        public string CurrentUserLogin => _currentUserLogin;
    }
}
