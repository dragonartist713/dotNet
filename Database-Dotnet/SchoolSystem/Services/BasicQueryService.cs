using SchoolSystem.Models;
using SchoolSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SchoolSystem.Services;

public class BasicQueryService{
    private ApplicationDbContext _context;
		
		// TODO: Use dependency injection to initialize the database context.
    public BasicQueryService() {
			
    }

    public List<string> GetAllInstructorNames(){ 
	    // TODO: Implement.
    }

    public List<string> GetStudentsInCourse(string courseName){ 
        // TODO: Implement.
    }

    public List<string> GetDepartmentsWithMoreThanOneCourses(){ 
        // TODO: Implement.
    }

    public string GetDepartmentWithMostCourses(){ 
        // TODO: Implement.
    }

    public List<string> GetStudentsEnrolledInMoreThanFiveCourses(){ 
	    // TODO: Implement.
    }

    public List<string> GetInstructorsInDepartment(string departmentName){ 
	    // TODO: Implement.
    }

    public List<string> GetCoursesByInstructor(string instructorName){ 
	    // TODO: Implement.
    }

    public List<string> GetStudentsWithNoCourses(){ 
        // TODO: Implement.
    }

    public string GetInstructorWithMostCourses(){
        // TODO: Implement.
    }

    /*
        This method groups students by the year they enrolled. 
        After grouping, it then converts the grouped data into a Dictionary. 
        The keys of the dictionary are enrollment years (group.Key), 
        and the values are lists of student names who enrolled in the 
        respective year (group.Select(s => s.Name).ToList()).
    */   
    public Dictionary<int, List<string>> GetStudentsGroupedByEnrollmentYear(){ 
        // TODO: Implement.
    }


    /*
        This method groups courses by the department name. After grouping, it 
        then converts the grouped data into a Dictionary. The keys of the 
        dictionary are department names (group.Key), and the values are lists of 
        course names that belong to the respective department 
        (group.Select(c => c.CourseName).ToList()).
    */
    public Dictionary<string, List<string>> GetCoursesGroupedByDepartment(){ 
				// TODO: Implement.
    }

    /*
        In this method, we first use SelectMany to flatten the collection of students along with their 
        associated courses into a single collection. Here, we're using an overload of SelectMany that 
        projects each student and course into a new anonymous object.

        Then we group these objects by the course name (sc.course.CourseName), and finally, we construct a 
        dictionary where each key is a course name and each value is a list of last names of the students enrolled in that course. 
        Note that sc is a shorthand for the anonymous object with properties student and course.

    */
    public Dictionary<string, List<string>> GetStudentsGroupedByCourse(){
        // TODO: Implement.
    }





}