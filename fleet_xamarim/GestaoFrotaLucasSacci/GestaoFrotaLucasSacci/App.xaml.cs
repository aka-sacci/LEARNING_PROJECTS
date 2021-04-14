using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GestaoFrotaLucasSacci.Model;
using System.Collections.Generic;
using GestaoFrotaLucasSacci.views.screen;

namespace GestaoFrotaLucasSacci
{
    public partial class App : Application
    {
        public static List<Veiculo> listaVeiculos = new List<Veiculo>();
        public static List<Abastecimento> listaAbastecimento = new List<Abastecimento>();
        public static int ultimoseq = 1;
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            var pagina = new screenVeiculo();
            MainPage = new NavigationPage(pagina);
            listaVeiculos.Add(new Veiculo() { 
            Placa = "LUL4022",
            Fabricante = "Fiat",
            Modelo = "Tempra",
            Cor = "Prata",
            Ano_Modelo = 1994,
            KM = 1313.13f
            });

            listaAbastecimento.Add(new Abastecimento()
            {
                KM = 13.13f,
                Litros = 13f,
                ValorTotal = 13.00f,
                Data = DateTime.Now,
                SEQ = 1

            }); ;
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
