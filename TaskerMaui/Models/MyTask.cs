using PropertyChanged;

namespace TaskerMaui.Models
{
    public class MyTask : BaseModel
    {
        public string Name { get; set; }
        public bool Completed { get; set; }
        public int CategoryId { get; set; }
        public string TaskColor { get; set; }
    }
}
