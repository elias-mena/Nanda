﻿using Nanda.BaseDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace Nanda
{
    [XamlCompilation(XamlCompilationOptions.Compile)]



    public partial class Carrito : ContentPage
    {
        public List<Products> Products { get; private set; }
        public Carrito(List<Products> Carrito)
        {
            InitializeComponent();
            Products = Carrito;
            int total = (from product in Products select product).Count();
            BindingContext = this;
        }
        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            _ = e.Item as Products;

        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            _ = e.SelectedItem as Products;
        }
    }
}