using System.Threading.Tasks;
using PhoneSystem___LOLDESIGN.DTO;
using PhoneSystem___LOLDESIGN.Models;

namespace SmartSchool_WebAPI.Data
{
    public interface IRepository
    {
        void Update<T>(T entity) where T : class;
        Task<Relation[]> GetRelations();
        Task<RelationDTO[]> GetRelationsPPM(int from, int to);
    }
}