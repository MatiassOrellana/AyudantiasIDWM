namespace Ayudantia1.src.Models
{
    public class User
    {
        public int id { get; set; }

        public String name { get; set; }

        public String email { get; set; }

        public String password  { get; set; }

        public int roleId { get; set; }

        public Role role { get; set; }
    }
}