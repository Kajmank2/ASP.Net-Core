using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Komis.Models
{
    public class SamochodRepository : ISamochodRepository
    {

        private readonly AppDbContext _appDbContext;

        public SamochodRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Samochod PobierzSamochodPoId(int SamochodId)
        {
            return _appDbContext.Samochody.FirstOrDefault(x => x.Id == SamochodId);
        }

        public IEnumerable<Samochod> PobierzWszystkieSamochody()
        {
            return _appDbContext.Samochody;
        }
    }
}
