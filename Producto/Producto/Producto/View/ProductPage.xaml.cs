using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using Producto.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Producto.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductViewModel : ContentPage
    {
        public ProductViewModel()
        {
            InitializeComponent();

            BindingContext = new ProductViewModel();
        }
    }
}