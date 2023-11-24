using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Abstractions;
using Attribute = Domain.Entities.Attribute;

namespace Domain.Entities

{
    public class CategoryAttribute : BaseEntity
    {
        public CategoryAttribute(int id, int categoryId, int attributeId) : base(id)
        {
            CategoryId = categoryId;
            AttributeId = attributeId;
        }

        public CategoryAttribute(int? categoryId, int? attributeId) : base(0)
        {
            CategoryId = categoryId;
            AttributeId = attributeId;
        }

        public CategoryAttribute(int id) : base(id)
        {
        }
        

        [ForeignKey(nameof(Category))]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        [ForeignKey(nameof(Attributive))]
        public int? AttributeId { get; set; }
        public Attribute Attributive { get; set; }
    }
}