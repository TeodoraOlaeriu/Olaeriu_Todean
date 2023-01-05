﻿using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olaeriu_Todean.Models
{
    public class Clinica
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [SQLite.MaxLength(250), SQLite.NotNull]
        public string NumeClinica { get; set; }

        [SQLite.MaxLength(250), SQLite.NotNull]
        public string Adresa { get; set; }
        public string DetaliiClinica
        {
            get
            {
                return NumeClinica + " "+ Adresa;
            } }
        [OneToMany]
        public List<Programare> Programari { get; set; }
    }
}
