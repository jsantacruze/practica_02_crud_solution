using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_02_crud_desktop
{
    public partial class PERSONA 
    {
        public override string ToString()
        {
            return this.PERSONA_ID.ToString() + " | " + this.PERSONA_APELLIDOS + " " + this.PERSONA_NOMBRES;
        }

    }
}
