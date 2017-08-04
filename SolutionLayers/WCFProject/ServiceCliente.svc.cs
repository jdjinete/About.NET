using ModeloDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFProject
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceCliente" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceCliente.svc o ServiceCliente.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceCliente : IServiceCliente
    {
        ClienteRepositorio a = new ClienteRepositorio();
          
        public string insertCliente(tbCliente c)
        {
            return a.insertCliente(c);
        }
        public string updateCliente(tbCliente c)
        {
            return a.updateCliente(c);
        }
        public string deleteCliente(tbCliente c)
        {
            return a.deleteCliente(c);
        }
        public List<procSelectClientes_Result> selectCliente()
        {
            return a.selectCliente().ToList();
        }
    }
}
