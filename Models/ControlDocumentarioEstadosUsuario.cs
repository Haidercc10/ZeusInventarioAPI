﻿using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ControlDocumentarioEstadosUsuario
    {
        public decimal Iden { get; set; }
        public decimal Sel { get; set; }
        public decimal IdAsociacion { get; set; }
        public string Usuario { get; set; } = null!;
    }
}
