using System.Threading.Tasks;
using Abp.Application.Services;
using ASP.NET.Authorization.Accounts.Dto;

namespace ASP.NET.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
