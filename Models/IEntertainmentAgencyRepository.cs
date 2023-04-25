using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace juandm_Final413.Models
{
    public interface IEntertainmentAgencyRepository
    {
        IQueryable<Entertainers> Entertainers { get; }

        void Add(Entertainers entertainer)
        {

        }
        void Update(Entertainers entertainer)
        {

        }
        void Delete(Entertainers entertainer)
        {

        }
    }
    
    
}
