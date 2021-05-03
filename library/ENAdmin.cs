using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENAdmin
    {
        public ArrayList MostrarUsuarios()
        {
            ArrayList lista = new ArrayList();
            CADAdmin admin = new CADAdmin();
            lista = admin.MostrarUsers();

            return lista;
        }
    }
}
