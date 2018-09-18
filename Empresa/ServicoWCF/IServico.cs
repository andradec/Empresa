using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicoWCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IServico" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IServico
    {
        [OperationContract]
        bool inserir(empresa empresa);
        [OperationContract]
        List<empresa> Listar();
    }
}
