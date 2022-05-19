using Microsoft.AspNetCore.Mvc;
using PhoneSystem___LOLDESIGN.DTO;
using SmartSchool_WebAPI.Data;
using TaskExtensions = System.Data.Entity.Utilities.TaskExtensions;

namespace PhoneSystem___LOLDESIGN.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RelationsController : ControllerBase{
    private readonly IRepository _repo;


    public RelationsController(IRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("/api/getAll")] 
    public async Task<IActionResult> GetAll()    
    {
        try
        {
            var result = await _repo.GetRelations();

            return Ok(result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    [HttpGet("/api/getPPM/{from}/{to}")] 
    public async Task<IActionResult> GetAllppm(int from, int to)    
    {
        try
        {
            var result = await _repo.GetRelationsPPM(from,to);

            return Ok(result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}