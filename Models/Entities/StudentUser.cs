namespace Kodlama_ioHomePageClone.Models.Entities
{
    public class StudentUser : BaseUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string AccountsLink { get; set; }


        public List<Course>? Courses { get; set; }
    }



}
