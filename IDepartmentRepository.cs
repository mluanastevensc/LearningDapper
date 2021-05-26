using System;
using System.Collections.Generic;

namespace INTROSQL
{
    public interface IDepartmentRepository
    {
        public IEnumerable<Departments> GetAllDepartments();

    }
}
