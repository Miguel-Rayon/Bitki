using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.IO;
using Bitki.Tablas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bitki.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UI_consulta : ContentPage
    {
        private SQLiteAsyncConnection _conn;
        public string nom, ub, des;
        public UI_consulta(string nombre, string ubicacion, string descripcion)
        {
            InitializeComponent();
            _conn = DependencyService.Get<ISQLiteDB>().GetConnection();
            nom = nombre;
            ub = ubicacion;
            des = descripcion;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Nombre.Text = nom;
            Ubicacion.Text = ub;
            Descipcion.Text = des;
        }
        private void btn_regresar(object seder, EventArgs e)
        {
            Navigation.PushAsync(new UI_lista());
        }
    }
}