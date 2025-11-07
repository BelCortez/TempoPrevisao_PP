using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempoPrevisao_PP.Service;

internal interface IclimaService
{
    Task<Models.Clima.Rootobject> BuscarClima(string cidade);
}
