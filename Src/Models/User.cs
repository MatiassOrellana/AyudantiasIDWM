namespace Ayudantia1.src.Models
{
    public class User
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public required string Password  { get; set; }

        public int RoleId { get; set; }

        public required Role Role { get; set; }
    }
}