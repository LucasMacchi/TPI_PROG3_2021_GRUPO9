using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_PROG_3_Grupo9
{
    public class LastSession
    {
        public string[] todosArchivos;
        public string direccion;

        public LastSession(string[] todosArchivos, string direccion)
        {
            this.todosArchivos = todosArchivos;
            this.direccion = direccion;
        }

        public LastSession()
        {
        }


    }
}
