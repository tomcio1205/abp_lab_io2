using System.Threading.Tasks;
using Abp.Application.Services;
using LABIO.Sessions.Dto;

namespace LABIO.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
