using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IStudentRepository
    {
        public void InsertStudent(Student std );


        public List<Student> GetAllStudent();

        public Student GetLoByName(string name);

        public void UpdateStudent(Student name);

        public void DeleteStudent(long Id);
    }   
}
