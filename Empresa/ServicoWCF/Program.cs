using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServicoWCF
{
    class program
    {
        static void Main(string[] args)
        {

            ServiceHost host = new ServiceHost(typeof(Servico), new Uri[] { });
            host.Open();
            Console.WriteLine("Serviço iniciado!");
            Console.WriteLine("Precione qualquer tecla para finalizar...");
            Console.ReadKey();
            host.Close();

        }
    }
}
