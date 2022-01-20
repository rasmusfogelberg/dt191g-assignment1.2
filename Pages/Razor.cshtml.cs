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
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Syllabus { get; set; } = string.Empty;
  }

  public RazorModel(ILogger<RazorModel> logger)
  {
    _logger = logger;

    Courses = new List<Course>
        {
          new Course { Id = 1, Code = "DT057G", Name = "Webbutveckling I", Syllabus = "https://www.miun.se/utbildning/kursplaner-och-utbildningsplaner/Sok-kursplan/kursplan/?kursplanid=22782" },
          new Course { Id = 2, Code = "DT084G", Name = "Introduktion till programmering i JavaScript", Syllabus = "https://www.miun.se/utbildning/kursplaner-och-utbildningsplaner/Sok-kursplan/kursplan/?kursplanid=30554" },
          new Course { Id = 3, Code = "DT163G", Name = "Digital bildbehandling för webb", Syllabus = "https://www.miun.se/utbildning/kursplaner-och-utbildningsplaner/Sok-kursplan/kursplan/?kursplanid=24403" },
          new Course { Id = 4, Code = "GD008G", Name = "Typografi och form för webb", Syllabus = "https://www.miun.se/utbildning/kursplaner-och-utbildningsplaner/Sok-kursplan/kursplan/?kursplanid=24399" },
          new Course { Id = 5, Code = "DT003G", Name = "Databaser", Syllabus = "https://www.miun.se/utbildning/kursplaner-och-utbildningsplaner/Sok-kursplan/kursplan/?kursplanid=21595" },
          new Course { Id = 6, Code = "DT093G", Name = "Webbutveckling II", Syllabus = "https://www.miun.se/utbildning/kursplaner-och-utbildningsplaner/Sok-kursplan/kursplan/?kursplanid=27133" },
          new Course { Id = 7, Code = "DT068G", Name = "Webbanvändbarhet", Syllabus = "https://www.miun.se/utbildning/kursplaner-och-utbildningsplaner/Sok-kursplan/kursplan/?kursplanid=30563" },
          new Course { Id = 8, Code = "DT197G", Name = "Webbdesign för CMS", Syllabus = "https://www.miun.se/utbildning/kursplaner-och-utbildningsplaner/Sok-kursplan/kursplan/?kursplanid=30728" },
          new Course { Id = 9, Code = "IK060G", Name = "Projektledning", Syllabus = "https://www.miun.se/utbildning/kursplaner-och-utbildningsplaner/Sok-kursplan/kursplan/?kursplanid=27003" },
          new Course { Id = 10, Code = "DT173G", Name = "Webbutveckling III", Syllabus = "https://www.miun.se/utbildning/kursplaner-och-utbildningsplaner/Sok-kursplan/kursplan/?kursplanid=22706" },
        };
  }
  public void OnGet()
  {
  }
}

