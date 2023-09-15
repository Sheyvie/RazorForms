using System.ComponentModel.DataAnnotations;

namespace BlazorForm.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        [Range(18,45)]
        public int Age { get; set; }
        [Required]
        public string Gender { get;set; } = string.Empty;
       public  List< Role> role =new List< Role>();

    }
    public class Role
    {

        public int Id { get; set; }
        [Required]
        public string UserRole { get; set; } = string.Empty;
        
    }
}
