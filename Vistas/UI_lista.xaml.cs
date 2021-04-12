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
using System.Collections.ObjectModel;

namespace Bitki.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UI_lista : ContentPage
    {
        private SQLiteAsyncConnection _conn;
        private ObservableCollection<T_Registros> _DatosRegistros;
        public UI_lista()
        {
            InitializeComponent();
            _conn = DependencyService.Get<ISQLiteDB>().GetConnection();
        }
        protected async override void OnAppearing()
        {
            var Resultado = await _conn.Table<T_Registros>().ToListAsync();
            _DatosRegistros = new ObservableCollection<T_Registros>(Resultado);
            ListaPlantas.ItemsSource = _DatosRegistros;
            base.OnAppearing();
        }
        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            var Obj = (T_Registros)e.SelectedItem;
            var item1 = Obj.Nombre.ToString();
            var item2 = Obj.Ubicacion.ToString();
            var item3 = Obj.Descripcion.ToString();
            var NOM = item1;
            var UB = item2;
            var DES = item3;
            try
            {
                Navigation.PushAsync(new UI_consulta(NOM, UB, DES));
            }
            catch (Exception)
            {
                throw;
            }

        }
        private void btn_agregar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UI_registro());
        }
    }
}