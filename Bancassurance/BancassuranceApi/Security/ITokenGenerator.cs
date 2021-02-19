using BancassuranceApi.ViewModels;

namespace BancassuranceApi.Security
{
    public interface ITokenGenerator
    {
        string Generate(SessionBridgeVm sessionBridge);
    }
}