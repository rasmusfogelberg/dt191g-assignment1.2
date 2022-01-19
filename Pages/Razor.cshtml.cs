using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_tutorial.Pages;

public class RazorModel : PageModel
{
  private readonly ILogger<RazorModel> _logger;
  public List<Course> Courses { get; set; }


  public class Course
  {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
  }

  public RazorModel(ILogger<RazorModel> logger)
  {
    _logger = logger;

    Courses = new List<Course>
        {
            new Course { Id = 1, Name = "Course 1" },
            new Course { Id = 2, Name = "Course 2" },
            new Course { Id = 3, Name = "Course 3" }
        };
  }

  public void OnGet()
  {
  }
}

