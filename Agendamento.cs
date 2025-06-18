using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaBarbearia;

namespace AgendaBarbearia
{
    public class Agendamento
    {
        public string NomeCliente { get; set; }
        public string Servico { get; set; }
        public DateTime DataHora { get; set; }

        public string Sevicodocliente { get; set; }

        public override string ToString()
        {
            return $"{DataHora:dd/MM/yyyy HH:mm} - {NomeCliente} - {Servico}";
        }
    }
}


