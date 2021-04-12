using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Bitki.Tablas;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bitki.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UI_inicio : ContentPage
    {
        private SQLiteAsyncConnection _conn;
        public UI_inicio()
        {
            InitializeComponent();
            _conn = DependencyService.Get<ISQLiteDB>().GetConnection();
        }
        private void btn_lista(object sender, EventArgs e)
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MySQLite.db3");
            var db = new SQLiteConnection(databasePath);
            db.CreateTable<T_Registros>();
            Navigation.PushAsync(new UI_lista());
        }
    }
}