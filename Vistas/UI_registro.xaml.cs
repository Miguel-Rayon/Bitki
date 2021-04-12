using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Bitki.Tablas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace Bitki.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UI_registro : ContentPage
    {
        private SQLiteAsyncConnection _conn;
        public UI_registro()
        {
            InitializeComponent();
            _conn = DependencyService.Get<ISQLiteDB>().GetConnection();
        }
        protected void btn_registrar(object sender, EventArgs e)
        {
            var Datos = new T_Registros { Nombre = nombre.Text, Ubicacion = ubicacion.Text, Descripcion = descripcion.Text };
            _conn.InsertAsync(Datos);
            LimpiarFormulario();
            DisplayAlert("Mensaje", "Registro Exitoso", "Aceptar");
            Navigation.PushAsync(new UI_lista());


        }
        void LimpiarFormulario()
        {
            nombre.Text = "";
            ubicacion.Text = "";
            descripcion.Text = "";
        }
    }
}