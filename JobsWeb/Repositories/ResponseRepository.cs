using JobsWeb.Enums;
using JobsWeb.Interfaces;
using JobsWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace JobsWeb.Repositories;

public class ResponseRepository : IResponseRepository
{
    private readonly DataBaseContext _context; 
    public ResponseRepository(DataBaseContext context)
    {
        this._context = context;
    }
    public async Task<List<Response>> AddResponse(ResponseDTO response)
    {
        var newResponse = new Response
        {
            Id = new Guid(),
            Status = ResponseStatus.NotViewed,
            User = response.User,
            Vacancy = response.Vacancy,
            ResponseDate = response.ResponseDate
        };
        await _context.Responses.AddAsync(newResponse);
        await _context.SaveChangesAsync();
        return await _context.Responses.ToListAsync();
    }
}