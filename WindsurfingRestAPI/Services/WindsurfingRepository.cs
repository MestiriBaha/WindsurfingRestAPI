using WindsurfingRestAPI.Entities;
using Microsoft.EntityFrameworkCore;
using WindsurfingRestAPI.DBcontext;

namespace WindsurfingRestAPI.Services
{
    public class WindsurfingRepository : IWindsurfingRepository
    {
        private readonly Windsurfdatabase _context;
        public WindsurfingRepository(Windsurfdatabase context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context)); 
        }

        public void AddSpot(Spot spot)
        {
            if (spot == null) {  throw new ArgumentNullException(nameof(spot)); }   
            _context.Spots.Add(spot);   
        }

        public void AddSurfer(Windsurfer windsurfer)
        {
            if (windsurfer == null) { throw new ArgumentNullException(nameof(windsurfer)); }
            _context.Windsurfers.Add(windsurfer);   
        }

        public void DeleteSpot(Spot spot)
        {
            _context.Spots.Remove(spot);
                }

        public async Task<IEnumerable<Windsurfer>> GetAllSPOTWindsurfers(string SPOTname)
        {
            if (SPOTname == null)
            {
                throw new ArgumentNullException(nameof(SPOTname));
            }
            return await _context.Windsurfers.Include(search => search.Spots.Where(x => x.Name == SPOTname)).ToListAsync();
        }
       
        public async Task<IEnumerable<Spot>> GetSpotsAsync()
        {
            return await _context.Spots.OrderByDescending(x=> x.Hearts).ToListAsync(); 
                }

        

        public void RemoveSurfer(Windsurfer windsurfer)
        {
            _context.Windsurfers.Remove(windsurfer); 
            
        }

        public async Task<bool> SaveAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);

        }

        public void UpdateSpot(Spot spot)
        {
                //No code for this implementation which is obvious ! 
            }

        public void UpdateSurfer(Windsurfer windsurfer)
        {
            //No code for this implementation which is obvious ! 
        }
        public async Task<IEnumerable<Spot>> GetSpotsAsync(int windsurferid)
        {
                   // if (  windsurfer == null ) { throw new ArgumentNullException(nameof(windsurfer)); } 
                    return await _context.Windsurfers.Where(x=> x.ID ==windsurferid ).SelectMany(x => x.Spots).ToListAsync();   
         }
        public async Task<Boolean> IswindsurferExistsAsync(int windsurferid)
        {
            return await _context.Windsurfers.Where(_x => _x.ID ==windsurferid).AnyAsync();
        }


    }
}
