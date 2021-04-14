using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoFrotaLucasSacci.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestaoFrotaLucasSacci.views.notabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class addAbastecimento : ContentPage
    {
        public Abastecimento adtAbastecimento = new Abastecimento();
        public addAbastecimento()
        {
            InitializeComponent();
            adtAbastecimento.SEQ = ++App.ultimoseq;
            adtAbastecimento.Data = DateTime.Now;
            BindingContext = adtAbastecimento;
            
        }

        private void gravar_Clicked(object sender, EventArgs e)
        {
            App.listaAbastecimento.Add(adtAbastecimento);
            Navigation.PopAsync();
        }
    }
}