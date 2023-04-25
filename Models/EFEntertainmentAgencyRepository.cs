using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace juandm_Final413.Models
{
    public class EFEntertainmentAgencyRepository : IEntertainmentAgencyRepository
    {
        private EntertainmentAgencyExampleContext context { get; set; }
        public EFEntertainmentAgencyRepository(EntertainmentAgencyExampleContext temp)
        {
            context = temp;
        }
        public IQueryable<Entertainers> Entertainers => context.Entertainers;
        //methods to add delete and update a record
        public void Add(Entertainers Entertainer)
        {
            context.Add(Entertainer);
            context.SaveChanges();
        }
        public void Update(Entertainers entertainer)
        {
            context.Update(entertainer);
            context.SaveChanges();
        }
        public void Delete(Entertainers Entertainer)
        {
            context.Entertainers.Remove(Entertainer);
            context.SaveChanges();
        }


    }
}
