namespace Kodlama_ioHomePageClone.Models
{
    // Category modeli
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        // İliskiler
        // Her Category e ait kurslari listeleyebilmek icin list turunde course ile iliskilendirdik

        public List<Course> Courses { get; set; }
    }

}
