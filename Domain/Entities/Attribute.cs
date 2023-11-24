using Domain.Entities.Abstractions;

namespace Domain.Entities
{
    public class Attribute : BaseDictionary
    {
        public Attribute(int id, string name) : base(id, name)
        {
        }

        public Attribute(string name) : this(0, name)
        {
        }
        public ICollection<CategoryAttribute> AttributesCategory { get; set; }

    }
}