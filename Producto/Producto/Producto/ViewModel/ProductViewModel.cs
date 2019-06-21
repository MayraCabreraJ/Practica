namespace Producto.ViewModel
{
    using Producto.Services;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    using Model;
    using GalaSoft.MvvmLight.Command;
    using Xamarin.Forms;
    using View;
    using System.Windows.Input;
    using System.Linq;
   

    public class ProductViewModel: BaseViewModel
    {
        #region Services
        private ApiService apiService;
       
        #endregion
        #region Attributes
        private ObservableCollection<Producto> productos;
        string name;
        double price;
       
        #endregion
        #region Properties
        public ObservableCollection<Producto> Productos
        {
            get { return this.productos; }

            set { SetValue(ref this.productos, value); }
        }
        public List<Producto> MyProductos{ get; set; }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                SetValue(ref this.name, value);
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                SetValue(ref this.price, value);
            }
        }
        #endregion
        #region Constructors
        public ProductViewModel()
        {
            this.Name = "Pan";
            this.Price = "42.0";
            this.apiService = new ApiService();
            this.LoadProductos();
        }

       #region Methods
        private async void LoadProductos()
        {
            var response = await this.apiService.GetList<Producto>
                (
         "http://35.209.34.163:5000/Products"
                                      
                   );
            if (!response.IsSuccess)
            {
                //this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Accept");
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }
            var list = (List<Producto>)response.Result;
            this.Productos = new ObservableCollection<Producto>(list);
        }
            private IEnumerable<ProductItemViewModel> ToProductoItemViewModel()
            {
            return MainViewModel.GetInstance().ProductList.Select(l => new PrdoductViewModel
               {
                   ProductId = 1.ProductId,
                   Name = 1.Name,
                   Price = 1.Price,
                    
                });
            }
        #endregion


    }
}