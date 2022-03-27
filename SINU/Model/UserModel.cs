using System.ComponentModel.DataAnnotations;



namespace SINU.UserModel
{
    public class User
    {

        [Key]
        public string IDNP { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


    }
}
