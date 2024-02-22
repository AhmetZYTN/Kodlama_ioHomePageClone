using Kodlama_ioHomePageClone.Models.Entities;

namespace Kodlama_ioHomePageClone.Models
{
    // Course modeli
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Completed { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }

        // İliskiler
        public Category Category { get; set; } // Her kursun bir categorysi ve egitmeni olmali
        public Instructor Instructor { get; set; }
        public StudentUser? Student { get; set; }
    }

}
