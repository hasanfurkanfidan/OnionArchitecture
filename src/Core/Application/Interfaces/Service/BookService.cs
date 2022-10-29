using Application.Dtos;
using Application.Interfaces.Repository;
using Application.Results;
using AutoMapper;

namespace Application.Interfaces.Service
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<IDataResult<List<BookDto>>> GetAllBooks()
        {
            var books = await _bookRepository.GetAll();
            var mappedBooks = _mapper.Map<List<BookDto>>(books);
            return new SuccessDataResult<List<BookDto>>(mappedBooks);
        }
    }
}
