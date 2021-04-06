using AppListView.Model;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppListView
{
    public partial class App : Application
    {
        public static List<Visitante> minhaLista = new List<Visitante>();
        public static long ultimoId = 4;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            minhaLista.Add(new Visitante()
            {
                Id = 1,
                Nome = "Luciano",
                Descricao = "Visitante 1",
                End_image = "frame.jpeg"
            });
            Visitante v = new Visitante();
            v.Id = 2;
            v.Nome = "Joaquim";
            v.Descricao = "Visitante 2";
            v.End_image = "frame.jpeg";
            minhaLista.Add(v);

            v = new Visitante();
            v.Id = 3;
            v.Nome = "Maria";
            v.Descricao = "Visitante 3";
            v.End_image = "frame.jpeg";
            minhaLista.Add(v);

            minhaLista.Add(new Visitante()
            {
                Id = 4,
                Nome = "Beltrano",
                Descricao = "Visitante 4",
                End_image = ""
            });

            

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