using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infraestructura.Activos
{
    public class Depreciacion
    {
        public decimal[] Depreciar(Activo af)
        {
            switch (af.MetodoDepreciacion)
            {
                case MetodoDepreciacion.LineaRecta:
                    return DepreciacionLineaRecta(af);
                case MetodoDepreciacion.SDA:
                    return DepreciacionSDA(af);
            }

            return null;
        }
        private decimal[] DepreciacionLineaRecta(Activo activoFijo)
        {
            int vidaUtil = VidaUtil(activoFijo.TipoActivoFijo);
            return Enumerable.Repeat(activoFijo.ValorActivo / vidaUtil, vidaUtil).ToArray();
        }

        private decimal[] DepreciacionSDA(Activo activoFijo)
        {
            return null;
        }

        private int VidaUtil(TipoActivoFijo tipoActivoFijo)
        {
            switch (tipoActivoFijo)
            {
                case TipoActivoFijo.Edificio:
                    return 20;
                case TipoActivoFijo.Transporte:
                    return 5;
                case TipoActivoFijo.Maquinaria:
                    return 3;
                case TipoActivoFijo.Mobiliario:
                    return 2;
                case TipoActivoFijo.EquipoComputo:
                    return 1;
                default:
                    throw new ArgumentException("Tipo de activo fijo que ha ingresado no existe.");
            }
        }
    }
}
