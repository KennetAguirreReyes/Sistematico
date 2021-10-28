using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Activos
{
    public class ActivoModel
    {
        private Activo[] activoFijos;

        public void Create(Activo activoFijo)
        {
            Add(activoFijo, ref activoFijos);
            //if (activoFijos == null)
            //{
            //    activoFijos = new Activo[1];
            //    activoFijos[activoFijos.Length - 1] = activoFijo;
            //    return;
            //}

            //Activo[] temp = new Activo[activoFijos.Length + 1];
            //Array.Copy(activoFijos, temp, activoFijos.Length);

            //temp[temp.Length - 1] = activoFijo;
            //activoFijos = temp;
        }

        public Activo[] FindAll()
        {
            return activoFijos;
        }

        public int GetLastActivoFijoId()
        {
            return (activoFijos == null) ? 0 : activoFijos[activoFijos.Length - 1].Id;
        }

        private void Add(Activo p, ref Activo[] act)
        {
            if (act == null)
            {
                act = new Activo[1];
                act[act.Length - 1] = p;
                return;
            }

            Activo[] tmp = new Activo[act.Length + 1];
            Array.Copy(act, tmp, act.Length);
            tmp[tmp.Length - 1] = p;
            act = tmp;
        }
    }
}
