using Microsoft.AspNetCore.Mvc;


namespace MyFirstWebApplication.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private static School _school = new School();

    [HttpGet]
    public IActionResult GetStudents()
    {
        return Ok(_school.Students);
    }

    [HttpPost]
    public IActionResult AddStudent([FromBody] Student student)
    {
        _school.AddStudent(student);
        return Ok(student);
    }

    [HttpDelete("{schoolClass}/{geburtsdatum}")]
    public IActionResult DeleteStudent(string schoolClass, DateTime geburtsdatum)
    {
        var student = _school.Students.FirstOrDefault(s => s.SchoolClass == schoolClass && s.Geburtsdatum == geburtsdatum);

        if (student == null)
            return NotFound("Schüler nicht gefunden.");

        _school.Students.Remove(student);
        return Ok("Schüler gelöscht.");
    }
}
