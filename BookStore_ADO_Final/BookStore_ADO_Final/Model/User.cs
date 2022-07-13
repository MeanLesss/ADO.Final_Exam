using System.Drawing;

namespace BookStore_ADO_Final.Model
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PhotoDir { get; set; }
        public string Role { get; set; }
    }
}