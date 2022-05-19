using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhoneSystem___LOLDESIGN.Data;
using PhoneSystem___LOLDESIGN.DTO;
using PhoneSystem___LOLDESIGN.Models;

namespace SmartSchool_WebAPI.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
       
        public async Task<Relation[]> GetRelations()
        {
            IQueryable<Relation> query = _context.Relation;
            query = query.AsNoTracking().Select(t => t);
            return await query.ToArrayAsync();
        }
        
        public async Task<RelationDTO[]> GetRelationsPPM(int from, int to)
        {
            IQueryable<Relation> query = _context.Relation;
            query = query.AsNoTracking().Where(t => from == t.from && to == t.to).AsQueryable();
           var dto =  query.Select(t=>new RelationDTO()
            {
                pricePerMin = t.PricePerMin
            });
            return await dto.ToArrayAsync();
        }
    }
}