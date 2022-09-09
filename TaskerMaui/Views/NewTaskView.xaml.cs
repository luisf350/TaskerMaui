using TaskerMaui.Models;
using TaskerMaui.ViewModels;

namespace TaskerMaui.Views;

public partial class NewTaskView : ContentPage
{
	public NewTaskView()
	{
		InitializeComponent();
	}

    private async void AddTaskClicked(object sender, EventArgs e)
    {
        var vm = BindingContext as NewTaskViewModel;

        if (string.IsNullOrEmpty(vm.Task))
        {
            await DisplayAlert("Task Name", "You must enter the name of the task", "Ok");
            return;
        }

        var selectedCategory =
             vm.Categories.FirstOrDefault(x => x.IsSelected);

        if (selectedCategory == null) 
        { 
            await DisplayAlert("Invalid Selection", "You must select a category", "Ok");
            return;
        }

        var task = new MyTask
        {
            Name = vm.Task,
            CategoryId = selectedCategory.Id
        };
        vm.Tasks.Add(task);
        await Navigation.PopAsync();
    }

    private async void AddCategoryClicked(object sender, EventArgs e)
    {
        var vm = BindingContext as NewTaskViewModel;

        string category =
             await DisplayPromptAsync("New Categry",
             "Write the new category name",
             maxLength: 15,
             keyboard: Keyboard.Text);

        var r = new Random();

        if (!string.IsNullOrEmpty(category))
        {
            vm.Categories.Add(new Category
            {
                Id = vm.Categories.Max(x => x.Id) + 1,
                Color = Color.FromRgb(
                      r.Next(0, 255),
                      r.Next(0, 255),
                      r.Next(0, 255)).ToHex(),
                Name = category
            });
        }
    }
}