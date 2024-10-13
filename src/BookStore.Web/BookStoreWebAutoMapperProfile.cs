using AutoMapper;
using BookStore.Books;

namespace BookStore.Web;

public class BookStoreWebAutoMapperProfile : Profile
{
    public BookStoreWebAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        //Define your object mappings here, for the Web project
    }
}
