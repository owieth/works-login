using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;

namespace WebApplication2.Services
{
    public abstract class DbService<T> where T : class //kann für jenste klasse verwendet werden, t ist platzhalter für alle klassen
    {
        public readonly ApplicationDbContext _dbContext; //nach refactor in private setzen

        protected DbService(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        //daten speichern
        
        public bool Add(T item)
        {
            //check if exists
            if (item == null) return false;
            _dbContext.Set<T>().Add(item);
            _dbContext.SaveChanges();
            return true;
        }

        //daten auslesen
        //select all
        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        //daten löschen
        public bool Remove(T item)
        {
            if (item == null) return false;
            _dbContext.Set<T>().Remove(item);
            _dbContext.SaveChanges();
            return true;
        }

        //daten ändern
    }
}
