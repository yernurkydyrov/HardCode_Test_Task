using Domain.Entities.Abstractions;

namespace Domain.Entities

{
    public class Category : BaseDictionary
    {
        public Category()
        {
            
        }
        
        public Category(int id, string name) : base(0, name)
        {
        }

        public ICollection<CategoryAttribute> CategoryAttributes { get; set; }
    }
}