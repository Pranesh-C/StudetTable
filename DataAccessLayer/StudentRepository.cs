using DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;

namespace DataAccessLayer
{
    public class StudentRepository: IStudentRepository

    {

        StudentDbContext dbContext = null;

        public object Con { get; private set; }

        public StudentRepository(StudentDbContext context)
        {
            dbContext = context;
        }

        public void InsertStudent(Student loc)
        {

            try
            {
                dbContext.Add(loc);
                dbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public List<Student> GetAllStudent()
        {
            try
            {
                return dbContext.Students.ToList();

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public Student GetLoByName(string name)
        {
            try
            {
                return dbContext.Students.FirstOrDefault(X => X.Name == name);

            }
            catch (Exception ex)
            {
                throw;
            }

        }


        public void UpdateStudent(Student name)
        {
            try
            {
                dbContext.Add(name);
                dbContext.SaveChanges();


            }
            catch (Exception ex)
            {
                throw;


            }

        }


        public void DeleteStudent(long Id)
        {
            try
            {
                var count = dbContext.Students.Find(Id);
                dbContext.Add(count );
                dbContext.SaveChanges();


            }
            catch (Exception ex)
            {
                throw;


            }

        }

    }

}    


