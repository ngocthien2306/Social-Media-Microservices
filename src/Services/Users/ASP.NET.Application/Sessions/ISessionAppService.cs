using System.Threading.Tasks;
using Abp.Application.Services;
using ASP.NET.Sessions.Dto;

namespace ASP.NET.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
