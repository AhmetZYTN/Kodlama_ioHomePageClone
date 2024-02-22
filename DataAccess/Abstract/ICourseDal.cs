using Kodlama_ioHomePageClone.Models;

namespace Kodlama_ioHomePageClone.DataAccess.Abstract
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        List<Course> List();
        void Delete(Course course);
        void Update(Course course);
        void Insert(Course course);
    }
}
