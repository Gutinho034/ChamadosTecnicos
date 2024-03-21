using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class Chamados
    {
        public int CodigosChamados { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string Ocorrencia { get; set; }
        public string Problema { get; set; }
        public bool Concluidos { get; set; }
        public int fk_Cliente_CodigoCliente { get; set; }
        public int fk_Tecnicos_CodigoTecnico { get; set; }

    }
}
