using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
     public class AreaComun
        {
            public int ID_area { get; set; }
            public string Nombre { get; set; }
            public string Estatus { get; set; }
            public byte HrInicioActividades { get; set; }  // 0-23
            public byte HrFinActividades { get; set; }     // 0-23
            public int Anticipacion { get; set; }          // en días
            public int MaxHrsReservacion { get; set; }
            public bool RequiereAutorizacion { get; set; }
        }

    
}
