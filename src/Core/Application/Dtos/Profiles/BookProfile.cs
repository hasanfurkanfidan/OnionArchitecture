using AutoMapper;
using Domain.Entities;

namespace Application.Dtos.Profiles
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<Book, BookDto>();
        }
    }
}
