using System.Threading.Tasks;



namespace Core.Interfaces
{
    public interface IRatingsService
    {
        Task<int> AddRatingAsync(float rating, int MediaId);
    }
}