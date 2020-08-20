using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        ICollection<T> FindAll();
        T FindbyId(int id);
        bool Create(T Entity);
        bool Update(T Entity);
        bool Delete(T Entity);
        bool Save();
    }
}
