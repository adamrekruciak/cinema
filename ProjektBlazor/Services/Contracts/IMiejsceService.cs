using Kino.Models.Dtos;

namespace ProjektBlazor.Services.Contracts
{
    public interface IMiejsceService
    {
        Task<IEnumerable<MiejsceDto>> GetMiejsce();

        Task<MiejsceDto> UpdateMiejsce(UpdateSeatDto updateSeatDto);
    }
}
