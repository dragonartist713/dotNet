using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.Models;

public class Student{
    [Key]    
    public int Id {get;set;}
    [Required]
    public required string FirstName {get;set;}
    [Required]
    public required string LastName {get;set;}
    public DateTime? JoiningDate {get;set;}
    public virtual ICollection<Course> Courses {get; set;} = new List<Course>();
}