using Clinic_Registration_and_Management_System.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemClinc.BLL.Interface;
using SystemClinc.DAL.MyDbContext;

namespace SystemClinc.BLL.Repository
{
    public class GenaricRepository<T>:IGeneric<T> where T : class
    {
        private readonly ApplicationDbContext _context; //==> EMPTY 

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

       /*if(typeof(T) == typeof(Employee))
            {
               return (IEnumerable<T>)_context.Employees.Include(e=>e.Department).ToList();
                   
            }
            else { 
                  return  _context.Set<T>().ToList();
            
            }*/
        public IEnumerable<T> GetAll()
        {
            if (typeof(T) == typeof(Appointment))
            {
                return (IEnumerable<T>)_context.Appointments.Include(e =>e.Specialization).ToList();
            }
            else
            {
                return _context.Set<T>().ToList();

            }
        }
             //=> _context.Set<T>().ToList();


        public int Update(T item)
        {
            _context.Set<T>().Update(item);
            return _context.SaveChanges();
        }
    }
}
