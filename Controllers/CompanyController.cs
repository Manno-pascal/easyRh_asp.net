using api.Data;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;


[Route("api/company")]
[ApiController]
public class CompanyController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public CompanyController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_context.Companies.ToList());
    }
    
    [HttpGet("{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        
        return Ok(_context.Companies.Find(id));
    }
}