using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercicio01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class tabbedIndex : TabbedPage
    {
        public tabbedIndex()
        {
            InitializeComponent();
        }
    }
}