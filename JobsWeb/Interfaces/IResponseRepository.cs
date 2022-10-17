using JobsWeb.Models;

namespace JobsWeb.Interfaces;

public interface IResponseRepository
{
    Task<List<Response>> AddResponse(Response response);
}