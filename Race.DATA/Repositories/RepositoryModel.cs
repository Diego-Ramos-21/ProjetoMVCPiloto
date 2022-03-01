using Race.DATA.Interfaces;
using Race.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.DATA.Repositories
{
    public class RepositoryModel<T> : IRepositoryModel<T>, IDisposable where T : class
    {
        // Repositorio base
        protected RaceContext _Context;
        public bool _SaveChanges = true;
        public RepositoryModel(bool saveChanges)
        {
            _SaveChanges = saveChanges;
            _Context = new RaceContext();
        }
        public T AddEntity(T entity) // Adiciona a entidade ao DB
        {
            _Context.Set<T>().Add(entity);
            if (_SaveChanges) _Context.SaveChanges();
            return entity;
        }
        public void Delete(int id) => Delete(Get(id)); // Deleta um item especificado pelo ID
        public void Delete(T entity) // Deleta a entidade do DB
        {
            _Context.Set<T>().Remove(entity);
            if (_SaveChanges) _Context.SaveChanges();
        }
        public void Dispose() => _Context.Dispose();
        public T Get(int id) => _Context.Set<T>().Find(id); // Captura uma informação especifica para leitura do DB
        public List<T> GetAll() => _Context.Set<T>().ToList(); // Captura todas as informações para leitura do DB
        public void saveChanges() => _Context.SaveChanges(); // Salva as informações
        public T Update(T entity) // Atualiza as informações no DB
        {
            _Context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            if (_SaveChanges) _Context.SaveChanges();
            return entity;
        }
    }
}
