﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Categoria
    {
        //PROPIEDADES
        public int Id { get; set; }
        public string Descripcion { get; set; }

        //Sobreescribo el METODO ToString
        public override string ToString()
        {
            return Descripcion;
        }
    }
}