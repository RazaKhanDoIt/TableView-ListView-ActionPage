using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week9_ListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewAction : ContentPage
    {
        List<Employee> myEmployees = new List<Employee>();
        public ListViewAction()
        {
          
            myEmployees.Add(new Employee { Name = "Raza", Job = "Front End Dev", Picture = "https://play-lh.googleusercontent.com/MmLHNN4_lwIN7kMG7XWnOxSYbEju-FBMEn8oDj4Xt8t9EnnH6S6GQeMHJDWpGfeDOSpM" });
            myEmployees.Add(new Employee { Name = "Gurps", Job = "Yung Programming Gawd", Picture = "https://play-lh.googleusercontent.com/MmLHNN4_lwIN7kMG7XWnOxSYbEju-FBMEn8oDj4Xt8t9EnnH6S6GQeMHJDWpGfeDOSpM" });
            myEmployees.Add(new Employee { Name = "Shaun", Job = "Backend", Picture = "https://play-lh.googleusercontent.com/MmLHNN4_lwIN7kMG7XWnOxSYbEju-FBMEn8oDj4Xt8t9EnnH6S6GQeMHJDWpGfeDOSpM" });
            myEmployees.Add(new Employee { Name = "Alex", Job = "Mechanic", Picture = "https://play-lh.googleusercontent.com/MmLHNN4_lwIN7kMG7XWnOxSYbEju-FBMEn8oDj4Xt8t9EnnH6S6GQeMHJDWpGfeDOSpM" });

            InitializeComponent();

            employeeList.ItemsSource = myEmployees;
        }

        private void employeeList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var SecondPage = new MainPage();
            SecondPage.BindingContext = myEmployees[e.SelectedItemIndex];
            Navigation.PushAsync(SecondPage);
        }
    }
}