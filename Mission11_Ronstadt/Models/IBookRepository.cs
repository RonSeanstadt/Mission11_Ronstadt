namespace Mission11_Ronstadt.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
