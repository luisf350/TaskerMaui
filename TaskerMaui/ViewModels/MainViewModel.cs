using System.Collections.ObjectModel;
using TaskerMaui.Models;

namespace TaskerMaui.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<MyTask> Tasks { get; set; }

        public MainViewModel()
        {
            FillData();
            Tasks.CollectionChanged += Tasks_CollectionChanged;
        }

        private void Tasks_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            UpdateData();
        }

        private void FillData()
        {
            Categories = new ObservableCollection<Category>
            {
                new Category{ Id=1, Name=".NET MAUI Course", Color="#CF14DF"},
                new Category{ Id=2, Name="Tutorials", Color="#df6f14"},
                new Category{ Id=3, Name="Shopping", Color="#14df80"}
            };
            Tasks = new ObservableCollection<MyTask>
            {
                new MyTask
                {
                    Name = "Upload exercise files",
                    Completed = false,
                    CategoryId = 1
                },
                new MyTask
                {
                    Name = "Plan next course",
                    Completed = false,
                    CategoryId = 1
                },
                new MyTask
                {
                    Name = "Update new ASP.NET video on YouTube",
                    Completed = false,
                    CategoryId = 2
                },
                new MyTask
                {
                    Name = "Fix Settings.cs class of the project",
                    Completed = false,
                    CategoryId = 2
                },
                new MyTask
                {
                    Name = "Update github repository",
                    Completed = true,
                    CategoryId = 2
                },
                new MyTask
                {
                    Name = "Bug eggs",
                    Completed = false,
                    CategoryId = 3
                },
                new MyTask
                {
                    Name = "Go for the pepperoni pizza",
                    Completed = false,
                    CategoryId = 3
                }
            };

            UpdateData();
        }

        public void UpdateData()
        {
            foreach (var c in Categories)
            {
                var tasks = Tasks.Where(x => x.CategoryId == c.Id).Select(x => x);
                var completed = tasks.Where(x => x.Completed).Select(x => x);
                var notCompleted = tasks.Where(x => !x.Completed).Select(x => x);

                c.PendingTask = notCompleted.Count();
                c.Percentage = (float)completed.Count() / (float)tasks.Count();
            }
            foreach (var t in Tasks)
            {
                t.TaskColor = Categories.FirstOrDefault(x => x.Id == t.CategoryId)?.Color;
            }
        }
    }
}
