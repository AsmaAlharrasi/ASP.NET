using CodeAcademy.BLL.Interface;
using CodeAcademy.DAL.Data;
using CodeAcademy.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.BLL.Repository
{
    public class GenaricRepository<T> : IGenaricRepository<T> where T :class
    {
        private readonly ApplicationDbContext _context;
        public GenaricRepository(ApplicationDbContext context)
        {
            _context = context;   
        }

        public int Create(T item)
        {
            _context.Set<T>().Add(item);
            return _context.SaveChanges();
        }

        public int Delete(T item)
        {
            _context.Set<T>().Remove(item);
            return _context.SaveChanges();
        }

        public T Get(int id)
           => _context.Set<T>().Find(id);



        public IEnumerable<T> GetAll()
        {
            if (typeof(T) == typeof(Employee))
            {
                return (IEnumerable<T>)_context.Employees.Include(e => e.Departments).ToList();

            }
            else
            {
                return _context.Set<T>().ToList();

            }


        }


        public int Update(T item)
        {
            _context.Set<T>().Update(item);
            return _context.SaveChanges();
        }
    }

}
