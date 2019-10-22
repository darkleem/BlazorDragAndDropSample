namespace BlazorDragSample.Data
{
    public enum TodoCategory
    {
        Todo = 0,
        Testing,
        Done
    }
    
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public TodoCategory Category { get; set; }
    }
}