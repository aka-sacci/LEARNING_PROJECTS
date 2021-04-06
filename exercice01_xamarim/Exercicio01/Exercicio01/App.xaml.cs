using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Exercicio01.Views;

namespace Exercicio01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var pagina = new tabbedIndex();
            MainPage = pagina;
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
