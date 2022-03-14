using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week9_ListView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new ListViewPages();
            // MainPage = new TableViewPage();
            //MainPage = new TypeCellsPage();
            MainPage = new NavigationPage (new ListViewAction());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
