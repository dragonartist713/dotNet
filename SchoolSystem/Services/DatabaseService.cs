using SchoolSystem.Models;
using SchoolSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SchoolSystem.Services;

public class DatabaseService {
    private ApplicationDbContext _context;
		
		// TODO: Use dependency injection to initialize the database context.
    public DatabaseService() {
			
    }

    // Get all students
    public async Task<List<Student>> GetAllStudents() {

    }

    public List<Student> GetAllStudentsWithCourses() {
        // Using Include() to load related Courses data

    }

    public async Task<List<Course>> GetAllCoursesWithStudents() {
        // Using Include() to load related Students data

    }

    // Get student by ID, with their courses
    public async Task<Student?> GetStudentById(int id) {
        
    }

    public async Task<Student?> GetStudentByIdTest(int id) {
        
    }

    // Add a new student
    public async Task AddStudent(Student student) {
        
    }

    // Example: Update a student
    public async Task UpdateStudent(Student student) {
       
    }

    public async Task UpdateStudentName(int studentId, string newFirstName, string newLastName) {
        // Find the student, update the name, and save changes

    }

    public void EnrollStudentInCourse(int studentId, int courseId) {
        // Fetch the student and course, then update the models and save changes
        
    }

    public async Task EnrollStudentInCourseAsync(int studentId, int courseId) {
        // Fetch the student and course, then update the models and save changes

    }

    public async Task DeleteStudent(int id) {
			// Delete the student with the passed id.
    }
    
}
