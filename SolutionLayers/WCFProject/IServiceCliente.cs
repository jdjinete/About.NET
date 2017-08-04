using ModeloDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFProject
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceCliente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceCliente
    {
        [OperationContract]
        string insertCliente(tbCliente c);

        [OperationContract]
         string updateCliente(tbCliente c);

        [OperationContract]
         string deleteCliente(tbCliente c);

        [OperationContract]
         List<procSelectClientes_Result> selectCliente();


    }
}
