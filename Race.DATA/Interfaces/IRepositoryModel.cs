using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.DATA.Interfaces
{
    public interface IRepositoryModel<T> where T : class
    {
        // Modelo para o repositorio
        List<T> GetAll();
        T Get(int id);
        T AddEntity(T entity);
        T Update(T entity);
        void Delete(int id);
        void Delete(T entity);
        void saveChanges();
    }
}
