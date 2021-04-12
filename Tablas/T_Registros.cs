using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace Bitki.Tablas
{
    public class T_Registros
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Nombre { get; set; }
        [MaxLength(255)]
        public string Ubicacion { get; set; }
        [MaxLength(255)]
        public string Descripcion { get; set; }
    }
}
