using PayPalWebSecurity.Data;
using PayPalWebSecurity.Models;
using PayPalWebSecurity.ViewModels;

namespace PayPalWebSecurity.Repositories
{
    public class UserRepo
    {
        ApplicationDbContext _context;

        public UserRepo(ApplicationDbContext context)
        {
            this._context = context;

        }

        public IEnumerable<UserVM> AllUsers()
        {
            IEnumerable<UserVM> users = _context.Users.Select(u => new UserVM() 
            { 
                Email = u.Email 
            });
            return users;
        }

        //public MyRegisteredUser GetUserName(string userName )
        //{
        //     var user = _context.MyRegisteredUsers.Select(u => u).Where(Email=>Email != null).FirstOrDefault();

        //    return user;
        //}
    }
}