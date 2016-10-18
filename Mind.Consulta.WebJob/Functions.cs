using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Consulta.WebJob
{
    public static class Functions
    {

        public static void ProcessarArquivo([QueueTrigger("endereco")] string mensagem, [Blob("endereco/{queueTrigger}", FileAccess.Read)]Stream arquivo)
        {
            using (var reader = new StreamReader(arquivo))
            {

            }
        }
    }
}
