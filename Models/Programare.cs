using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Olaeriu_Todean.Models
{
    public class Programare
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [SQLite.MaxLength(250), SQLite.NotNull, Unique]

        public string Descriere { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataProgramare { get; set; }
        [ForeignKey(typeof(Clinica))]
        public int ClinicaID { get; set; }

    }
}
