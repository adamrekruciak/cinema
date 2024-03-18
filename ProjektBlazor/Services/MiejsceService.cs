using Kino.Models.Dtos;
using ProjektBlazor.Services.Contracts;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Text;

namespace ProjektBlazor.Services
{
    public class MiejsceService : IMiejsceService
    {
        private readonly HttpClient httpClient;

        public MiejsceService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<MiejsceDto>> GetMiejsce()
        {
            try
            {
                var miejsca = await this.httpClient.GetFromJsonAsync<IEnumerable<MiejsceDto>>("api/Miejsce");
                return miejsca;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<MiejsceDto> UpdateMiejsce(UpdateSeatDto updateSeatDto)
        {
            try
            {
                var jsonRequest = JsonConvert.SerializeObject(updateSeatDto);
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json-patch+json");

                var response = await httpClient.PatchAsync($"api/Miejsce/{updateSeatDto.SeatId}", content);

                if(response.IsSuccessStatusCode) 
                {
                    return await response.Content.ReadFromJsonAsync<MiejsceDto>();
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
