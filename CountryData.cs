using lab4.DataModel;
using System.Collections.Generic;
using System.Linq;

namespace lab4
{
   
public class CountryData : DataSupertype
{
    public List<Country> GetAll()
    {
        return this.Context.Countries.ToList();
    }

    public List<Country> FindByCountryId(int countryId)
    {
        return this.Context.Countries.Where(p => p.country_id == countryId).ToList();
    }

    public List<Country> FindByCountryName(string countryName)
    {
        return this.Context.Countries.Where(p => p.country_name == countryName).ToList();
    }

    public List<Country> FindByCountryCapital(string countryCapital)
    {
        return this.Context.Countries.Where(p => p.country_capital == countryCapital).ToList();
    }

    public List<Country> FindByCountryPopulation(int countryPopulation)
    {
        return this.Context.Countries.Where(p => p.country_population == countryPopulation).ToList();
    }

    public List<Country> FindByCountryRating(int countryRating)
    {
        return this.Context.Countries.Where(p => p.country_rating == countryRating).ToList();
    }

    public void AddCountry(Country countryToAdd)
    {
        this.Context.Countries.Add(countryToAdd);
        this.SaveChanges();
    }

    public void RemoveCountry(Country countryToRemove)
    {
        this.Context.Countries.Remove(countryToRemove);
        this.SaveChanges();
    }
}
}
