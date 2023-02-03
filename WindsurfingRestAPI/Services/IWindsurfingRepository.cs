using WindsurfingRestAPI.Entities;

namespace WindsurfingRestAPI.Services
{
    public interface IWindsurfingRepository
    {
        Task<IEnumerable<Windsurfer>> GetAllSPOTWindsurfers(string SPOTname ); 
        void AddSurfer(Windsurfer windsurfer) ; 
        void RemoveSurfer(Windsurfer windsurfer) ;  
        void UpdateSurfer ( Windsurfer windsurfer) ;
        //******************************
        Task<IEnumerable<Spot>> GetSpotsAsync();
        Task<IEnumerable<Spot>> GetSpotsAsync(int windsurferid);
        Task<Boolean> IswindsurferExistsAsync (int windsurferid);   

        void AddSpot(Spot spot);
        void DeleteSpot(Spot spot);
        void UpdateSpot(Spot spot);
        Task<bool> SaveAsync();
    }
}
