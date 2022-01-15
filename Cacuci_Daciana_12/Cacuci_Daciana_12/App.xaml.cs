using Cacuci_Daciana_12.Services;
using Cacuci_Daciana_12.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Cacuci_Daciana_12.Data;

namespace Cacuci_Daciana_12
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }

        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
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
