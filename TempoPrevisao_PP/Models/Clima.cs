using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempoPrevisao_PP.Models
{
    public class Clima
    {

        public class Rootobject
        {
            public string cidade { get; set; }
            public string estado { get; set; }
            public string atualizado_em { get; set; }
            public Clima[] clima { get; set; }
        }

        public class ClimaDia
        {
            public string data { get; set; }
            public string condicao { get; set; }
            public int min { get; set; }
            public int max { get; set; }
            public int indice_uv { get; set; }
            public string condicao_desc { get; set; }
        }

    }
}
