using api.Data;
using api.Models;

namespace api.Service
{
    public class CityService : ICityService
    {
        private readonly DataContext dataContext;

        public CityService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<string> GetAllCities(string country)
        {
            return dataContext.Cities
                .Where(city => city.Country == country)
                .Select(city => city.Name)
                .Distinct()
                .Take(20)
                .ToList();
        }

        public void InsertCities(List<City> cities)
        {
            dataContext.Cities.AddRange(cities);
        }

        public void Save()
        {
            dataContext.SaveChanges();
        }
    }
}
