using System;
using System.CodeDom;
using System.Data.Entity;
using System.Linq;
using BookStore_ADO_Final.Model;

namespace BookStore_ADO_Final.Database
{
    public class UserAuthentication
    {
        public UserAuthentication()
        {
            
        }

        public User UserAuthenticating(string username,string password)
        {
            User user = null;
            using (DataContext db = new DataContext())
            {
                try
                {
                    user = db.Users.Single(u => u.Username == username && u.Password == password);
                }
                catch (Exception ex)
                {
                    
                }
            }
            return user;
        }
    }
}