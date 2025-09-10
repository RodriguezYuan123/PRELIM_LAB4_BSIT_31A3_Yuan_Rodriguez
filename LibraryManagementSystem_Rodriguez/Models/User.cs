namespace LibraryManagementSystem_Rodriguez.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public List<BorrowRecord> BorrowedBooks { get; set; } = new();
}