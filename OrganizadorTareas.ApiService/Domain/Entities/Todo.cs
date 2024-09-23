public class Todo {
    public required int Id { get; set; }
    public required string Name { get; set; }
    public  string? Description { get; set; }

    public DateTime? ExpectedDate  { get; set; } = null;
    public required DateTime CreationDate { get; set; }
    public bool IsCompleted => ExpectedDate != null;
}