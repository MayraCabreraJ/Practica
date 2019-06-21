using System;
using System.Collections.Generic;
using System.Text;
namespace Producto.ViewModel
{
    class MainViewModel
    {
        #region Properties
        public string Token { get; set; }
        public string TokenType { get; set; }
        #endregion

        #region ViewModels
        public ProductViewModel Producto { get; set; }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Producto = new ProductViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}
