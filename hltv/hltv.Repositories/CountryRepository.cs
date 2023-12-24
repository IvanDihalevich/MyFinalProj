using hltv.Core.context;
using hltv.Core.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hltv.Repositories
{
    public class CountryRepository
    {
        private readonly hltvContext _context;

        public CountryRepository(hltvContext context)
        {
            _context = context;
        }

        public IEnumerable<Country> GetAll() => _context.Country.ToList();

        public Country GetById(int countryId) => _context.Country.FirstOrDefault(country => country.CountryId == countryId);

        public int Add(Country country)
        {
            var obj = _context.Country.Add(country);
            _context.SaveChanges();
            return obj.Entity.CountryId;
        }

        public void Update(int id, Country updatedCountry)
        {
            try
            {
                var country = _context.Country.Find(id);

                if (country != null)
                {
                    _context.Entry(country).CurrentValues.SetValues(updatedCountry);
                    _context.SaveChanges();
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                Console.WriteLine($"Concurrency Exception: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database Update Exception: {ex.Message}");
                throw;
            }
        }

        public void Delete(int id)
        {
            var country = _context.Country.Find(id);

            if (country != null)
            {
                _context.Country.Remove(country);
                _context.SaveChanges();
            }
        }
    }
}
