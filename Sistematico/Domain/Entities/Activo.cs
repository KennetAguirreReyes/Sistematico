using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Activo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int VidaUtil { get; set; }
        public decimal ValorActivo { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public MetodoDepreciacion MetodoDepreciacion { get; set; }
        public TipoActivoFijo TipoActivoFijo { get; set; }
    }
}
