using Kodlama_ioHomePageClone.Models;

namespace Kodlama_ioHomePageClone.Business.Abstract
{
    public interface ICourseService
    {
        List<Course> GetList();
        void CourseAdd(Course course);
        void CourseDelete(int courseId);
        void CourseUpdate(Course course);
        Course GetCourseById(int courseId);
   
    }
}
