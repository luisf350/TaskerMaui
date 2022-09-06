using System.Collections.ObjectModel;
using TaskerMaui.Models;

namespace TaskerMaui.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Category> Categories { get; set; }

        public MainViewModel()
        {
            FillData();
        }

        private void FillData()
        {
            Categories = new ObservableCollection<Category>
            {
                new Category{ Id=1, Name=".NET MAUI Course", Color="#CF14DF"},
                new Category{ Id=2, Name="Tutorials", Color="#df6f14"},
                new Category{ Id=3, Name="Shopping", Color="#14df80"}
            };
        }
    }
}
