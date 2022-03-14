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
    public partial class ListViewPages : ContentPage
    {
        public ListViewPages()
        {
            List <Person> myListPerson = new List<Person>();
            myListPerson.Add(new Person { Name = "Raza", Age = "28" });
            myListPerson.Add(new Person { Name = "Gurps", Age = "24" });
            myListPerson.Add(new Person { Name = "Shaun", Age = "28" });
            myListPerson.Add(new Person { Name = "Alex", Age = "22" });
            InitializeComponent();

            listPerson.ItemsSource = myListPerson;



        }
    }
}