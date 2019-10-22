namespace BlazorDragSample.Data
{
    public class DragAndDropService
    {
        public object Data { get; set; }
        public void StartDrag(object data)
        {
            this.Data = data;
        }
    }
}