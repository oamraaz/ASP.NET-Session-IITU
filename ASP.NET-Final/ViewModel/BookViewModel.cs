using Microsoft.AspNetCore.Http;

namespace ASP.NET_Final.ViewModel
{
    public class BookViewModel
    {
        public string BooksName { get; set; }
        public int BooksPrice { get; set; }
        public IFormFile BooksPage { get; set; }
    }
}
