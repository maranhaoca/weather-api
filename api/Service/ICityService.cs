using api.Models;

namespace api.Service
{
    public interface ICityService
    {
        List<string> GetAllCities(string country);
        void InsertCities(List<City> cities);
        void Save();
    }
}