using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TempoPrevisao_PP.Models;

namespace TempoPrevisao_PP.Service
{
    public class climaService : IclimaService
    {
        HttpClient _client;
        JsonSerializerOptions _options;

        public climaService()
        {
            _client = new HttpClient();
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true            
            };
       
        }
              

        public async Task<Clima.Rootobject?> BuscarClima(string cidade)
        {
            Clima.Rootobject? rootobject = null;

            try
            { 
                var response = await _client.GetAsync($"https://api.exemplo.com/clima?cidade={cidade}");
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                rootobject = JsonSerializer.Deserialize<Clima.Rootobject>(json, _options);
            }
            catch (Exception ex)
            {
                // Trate o erro conforme necessário
            }

            return rootobject;
        }

    }
}
