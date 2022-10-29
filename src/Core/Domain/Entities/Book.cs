using Domain.Common;

namespace Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
    }
}
