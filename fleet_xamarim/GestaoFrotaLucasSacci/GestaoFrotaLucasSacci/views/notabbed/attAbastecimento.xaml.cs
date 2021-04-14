using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GestaoFrotaLucasSacci.Model;

namespace GestaoFrotaLucasSacci.views.notabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class attAbastecimento : ContentPage
    {
        public Abastecimento edtAbastecimento;
        public attAbastecimento()
        {
            InitializeComponent();
        }

        public attAbastecimento(Abastecimento abastecimento)
        {
            InitializeComponent();
            edtAbastecimento = new Abastecimento()
            {

                Data = abastecimento.Data,
                Litros = abastecimento.Litros,
                SEQ = abastecimento.SEQ,
                ValorTotal = abastecimento.ValorTotal,
                KM = abastecimento.KM
            };

            BindingContext = edtAbastecimento;
        }

        private void gravar_Clicked(object sender, EventArgs e)
        {
            foreach (Abastecimento ab in App.listaAbastecimento)
            {
                if (ab.SEQ == edtAbastecimento.SEQ)
                {
                    App.listaAbastecimento.Remove(ab);
                    App.listaAbastecimento.Add(edtAbastecimento);
                    break;
                }
            }
            Navigation.PopAsync();
        }
    }
}