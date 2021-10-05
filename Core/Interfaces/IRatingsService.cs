using System.Threading.Tasks;



namespace Core.Interfaces
{
    public interface IRatingsService
    {
        Task<int> AddRating(float rating, int MediaId);
    }
}