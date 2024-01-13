using CodeAcademy.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.BLL.Interface
{
    public interface IGenaricRepository<T> 
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        int Create(T  item);
        int Update(T item);
        int Delete(T item);

    }
}

        