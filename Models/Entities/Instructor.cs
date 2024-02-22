namespace Kodlama_ioHomePageClone.Models.Entities
{
    // Instructor modeli
    public class Instructor : BaseUser
    {
        public string Name { get; set; }

        // İliskiler
        public List<Course> Courses { get; set; }
    }

}
