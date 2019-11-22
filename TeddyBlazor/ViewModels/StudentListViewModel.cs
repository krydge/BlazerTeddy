
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeddyBlazor.Data;
using TeddyBlazor.Models;
using TeddyBlazor.Services;

namespace TeddyBlazor.ViewModels
{
    public class StudentListViewModel
    {
        public readonly IStudentRepository StudentRepository;
        public string NameFilter = "";
        public int ClassIdFilter = -1;

        public StudentListViewModel(IStudentRepository StudentRepository)
        {
            this.StudentRepository = StudentRepository;
        }

        public IEnumerable<Student> GetFilteredStudents()
        {
            if(ClassIdFilter > 0)
            {
                return StudentRepository.GetList()
                    .Where(s => s.Name.ToLower().StartsWith(NameFilter.ToLower()))
                    .Where(s => s.Courses.Where(c => c.CourseId == ClassIdFilter).Count() > 0);
            }
            else
            {
                return StudentRepository.GetList()
                    .Where(s => s.Name.ToLower().StartsWith(NameFilter.ToLower()));
            }
        }
    }
}