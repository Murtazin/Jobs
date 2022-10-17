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
    public async Task<List<Response>> AddResponse(Response response)
    {
        await _context.Responses.AddAsync(response);
        await _context.SaveChangesAsync();
        return await _context.Responses.ToListAsync();
    }
}