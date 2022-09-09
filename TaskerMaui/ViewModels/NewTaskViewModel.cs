using System.Collections.ObjectModel;
using TaskerMaui.Models;

namespace TaskerMaui.ViewModels
{
    public class NewTaskViewModel : BaseViewModel
    {
        public string Task { get; set; }
        public ObservableCollection<MyTask> Tasks { get; set; }
        public ObservableCollection<Category> Categories { get; set; }
    }
}
