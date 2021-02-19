using BancassuranceApi.Services;
using BancassuranceApi.Utils;
using BancassuranceApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancaPortal.Utils
{
    public class SessionLifeChecker : ISessionLifeChecker
    {
        private readonly IConfigReader _configReader;
        private readonly ISessionBridgeVmManager _sessionBridgeVmManager;

        public SessionLifeChecker(IConfigReader configReader, ISessionBridgeVmManager sessionBridgeVmManager)
        {
            _configReader = configReader;
            _sessionBridgeVmManager = sessionBridgeVmManager;
        }

        public bool IsExpired(string sessionId)
        {
            var sessionBridgeVm = _sessionBridgeVmManager.GetFromBasket(sessionId);
            if (sessionBridgeVm == null) return true;

            DateTime expiryDate = sessionBridgeVm.ExpiryDate;
            DateTime currentDate = DateTime.Now;

            int comparisonResult = currentDate.CompareTo(expiryDate);

            bool expired = comparisonResult >= 0;

            return expired;
        }
    }
}
