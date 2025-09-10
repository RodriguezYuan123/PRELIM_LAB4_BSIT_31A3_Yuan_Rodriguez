namespace LibraryManagementSystem_Rodriguez.Models;

public class BorrowRecord
{
    public int Id { get; set; }
    public Book Book { get; set; }
    public DateTime DateBorrowed { get; set; }
    public DateTime? DateReturned { get; set; }
}