using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class SQLWalksRepository : IWalkRepository
    {
        private readonly NZWalksDbContext dbContex;

        public SQLWalksRepository(NZWalksDbContext dbContext)
        {
            this.dbContex = dbContext;

        }
        public async Task<Walks> CreateAync(Walks walks)
        {
            await dbContex.Walks.AddAsync(walks);
            await dbContex.SaveChangesAsync();
            return walks;

        }

        public async Task<Walks?> DeleteAsync(Guid id)
        {
            var existingWalk = await dbContex.Walks.FirstOrDefaultAsync(x => x.Id == id);

            if(existingWalk == null)
            {
                return null;
            }

            dbContex.Walks.Remove(existingWalk);
            await dbContex.SaveChangesAsync();
            return existingWalk;
        }

        public async Task<List<Walks>> GetAllAsync(string? filterOn = null, string? filterQuery = null, 
            string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000)
        {
            var walks = dbContex.Walks.Include("Difficulty").Include("Region").AsQueryable();

            //Filtering
            if(string.IsNullOrWhiteSpace(filterOn) == false && string.IsNullOrWhiteSpace(filterQuery) == false)
            {
                if(filterOn.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    walks = walks.Where(x => x.Name.Contains(filterQuery));
                }
            }

            //Sorting
            if (string.IsNullOrWhiteSpace(sortBy)==false)
            {
                if(sortBy.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    walks =isAscending?walks.OrderBy(x => x.Name):walks.OrderByDescending(x => x.Name);
                }
                else if(sortBy.Equals("Length", StringComparison.OrdinalIgnoreCase))
                {
                    walks = isAscending ? walks.OrderBy(x => x.LengthInKm):walks.OrderByDescending(x => x.LengthInKm);
                }
            }

            //Pagination
            var skipResults = (pageNumber - 1) * pageSize;

            return await walks.Skip(skipResults).Take(pageSize).ToListAsync();
            //return await dbContex.Walks.Include("Difficulty").Include("Region").ToListAsync();
        }

        public async Task<Walks> GetByIdAsync(Guid id)
        {
            return await dbContex.Walks
                .Include("Difficulty")
                .Include("Region").FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Walks> UpdateAsync(Guid id, Walks walks)
        {
            var existingWalk = await dbContex.Walks.FirstOrDefaultAsync(x => x.Id == id);

            if (existingWalk == null )
            {
                return null;
            }

            existingWalk.Name = walks.Name;
            existingWalk.Description = walks.Description;
            existingWalk.LengthInKm = walks.LengthInKm;
            existingWalk.DifficultyID = walks.DifficultyID;
            existingWalk.RegionId = walks.RegionId;

            await dbContex.SaveChangesAsync();

            return existingWalk;
        }
    }
}
