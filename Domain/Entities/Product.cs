using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Abstractions;

namespace Domain.Entities

{
    public class Product : BaseEntity
    {
        public Product(int id, int categoryId) : base(id)
        {
            CategoryId = categoryId;
        }

        public Product(int categoryId)
        {
            CategoryId = categoryId;
        }


        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}