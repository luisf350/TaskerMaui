using PropertyChanged;

namespace TaskerMaui.Models
{
    public class Category : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int PendingTask { get; set; }
        public float Percentage { get; set; }
        public bool IsSelected { get; set; }
    }
}
