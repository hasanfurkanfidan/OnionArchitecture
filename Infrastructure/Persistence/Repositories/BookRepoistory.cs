using Application.Interfaces.Repository;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class BookRepoistory : GenericRepository<Book>, IBookRepository
    {
        public BookRepoistory(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
