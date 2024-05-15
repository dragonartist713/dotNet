using SchoolSystem.Data;
using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolSystem.Services {
    public class SeedingService {
        private readonly ApplicationDbContext _context;

        public SeedingService(ApplicationDbContext context) {
            _context = context;
        }

        public void CreateInstructor(string firstName, string lastName, DateTime joiningDate) {
            var instructor = new Instructor {
                FirstName = firstName,
                LastName = lastName,
                JoiningDate = joiningDate
            };
            _context.Instructors.Add(instructor);
        }

        public void CreateStudent(string firstName, string lastName, DateTime joiningDate) {
            var student = new Student {
                FirstName = firstName,
                LastName = lastName,
                JoiningDate = joiningDate
            };
            _context.Students.Add(student);
        }

        public void CreateDepartment(string deptName) {
            var department = new Department {
                DeptName = deptName
            };
            _context.Departments.Add(department);
        }

        public void CreateCourse(string name, int instructorId, int departmentId) {
            var course = new Course {
                Name = name,
                InstructorId = instructorId,
                DepartmentId = departmentId
            };
            _context.Courses.Add(course);
        }

        public void AddStudentToCourse(int studentId, int courseId) {
            var student = _context.Students.Find(studentId);
            var course = _context.Courses.Find(courseId);
            if (student != null && course != null) {
                course.Students.Add(student);
            }
        }

        public void SeedDatabase() {
            if (_context.Instructors.Any() || _context.Students.Any() || _context.Departments.Any() || _context.Courses.Any()) {
                return; // Database has already been seeded
            }

            // Create Departments
            CreateDepartment("Computer Science");
            CreateDepartment("Mathematics");
            CreateDepartment("Physics");
            _context.SaveChanges();

            // Create Instructors
            CreateInstructor("John", "Doe", new DateTime(2010, 5, 1));
            CreateInstructor("Jane", "Smith", new DateTime(2012, 7, 23));
            CreateInstructor("Alan", "Turing", new DateTime(2015, 3, 14));
            _context.SaveChanges();

            // Get Department IDs
            var csDept = _context.Departments.First(d => d.DeptName == "Computer Science").Id;
            var mathDept = _context.Departments.First(d => d.DeptName == "Mathematics").Id;
            var physicsDept = _context.Departments.First(d => d.DeptName == "Physics").Id;

            // Get Instructor IDs
            var instructorJohn = _context.Instructors.First(i => i.LastName == "Doe").Id;
            var instructorJane = _context.Instructors.First(i => i.LastName == "Smith").Id;
            var instructorAlan = _context.Instructors.First(i => i.LastName == "Turing").Id;

            // Create Courses
            CreateCourse("Introduction to Computer Science", instructorJohn, csDept);
            CreateCourse("Advanced Mathematics", instructorJane, mathDept);
            CreateCourse("Quantum Physics", instructorAlan, physicsDept);
            _context.SaveChanges();

            // Create Students
            CreateStudent("Alice", "Johnson", new DateTime(2020, 9, 1));
            CreateStudent("Bob", "Brown", new DateTime(2021, 9, 1));
            CreateStudent("Charlie", "Davis", new DateTime(2021, 9, 1));
            _context.SaveChanges();

            // Get Student IDs
            var studentAlice = _context.Students.First(s => s.LastName == "Johnson").Id;
            var studentBob = _context.Students.First(s => s.LastName == "Brown").Id;
            var studentCharlie = _context.Students.First(s => s.LastName == "Davis").Id;

            // Get Course IDs
            var csCourse = _context.Courses.First(c => c.Name == "Introduction to Computer Science").Id;
            var mathCourse = _context.Courses.First(c => c.Name == "Advanced Mathematics").Id;
            var physicsCourse = _context.Courses.First(c => c.Name == "Quantum Physics").Id;

            // Add Students to Courses
            AddStudentToCourse(studentAlice, csCourse);
            AddStudentToCourse(studentBob, mathCourse);
            AddStudentToCourse(studentCharlie, physicsCourse);
            _context.SaveChanges();
        }
    }
}
