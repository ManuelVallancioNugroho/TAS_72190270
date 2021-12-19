using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFrontEnd.Models;

namespace BlazorFrontEnd.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> GetById(int id);
         Task<Student> Add(Student Student);

       Task<Student> Update(int id,Student student);
          Task Delete(int id);
    }
}