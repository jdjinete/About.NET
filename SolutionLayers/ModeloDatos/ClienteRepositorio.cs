using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDatos
{
    public class ClienteRepositorio
    {
        public List<procSelectClientes_Result> selectCliente()
        {
            using (ProyectoCapasEntities x=new ProyectoCapasEntities()) {
                return x.procSelectClientes().ToList();
            }
        
        }
        public string insertCliente(tbCliente c)
        {
            using (ProyectoCapasEntities x = new ProyectoCapasEntities())
            {
                return x.procCreateClientes(c.Nombre, c.FechaNacimiento, c.Sexo).ToString();
                
            }

        }
        public string updateCliente(tbCliente c)
        {
            using (ProyectoCapasEntities x = new ProyectoCapasEntities())
            {
                return x.procUpdateClientes(c.Nombre, c.FechaNacimiento, c.Sexo,c.IdCliente).ToString();

            }

        }
        public string deleteCliente(tbCliente c)
        {
            using (ProyectoCapasEntities x = new ProyectoCapasEntities())
            {
                return x.procDeleteClientes(c.IdCliente).ToString();

            }

        }
    }
}
