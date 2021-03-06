﻿using ClassPlanner.Domain.Entities;
using ClassPlanner.Domain.Interfaces;
using ClassPlanner.Infra.Context;
using ClassPlanner.Infra.Repositories.GenericRepository;

namespace ClassPlanner.Infra.Repositories.StudentRepository
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(MainContext dbContext) : base(dbContext)
        {
        }
    }
}
