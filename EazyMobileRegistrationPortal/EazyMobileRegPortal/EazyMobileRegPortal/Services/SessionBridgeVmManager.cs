using AutoMapper;
using EazyMobileRegPortal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EazyMobileRegPortal.Data
{
    public class SessionBridgeVmManager : ISessionBridgeVmManager
    {
        private readonly ISessionBasket _sessionBasket;

        public SessionBridgeVmManager(ISessionBasket sessionBasket)
        {
            _sessionBasket = sessionBasket;
        }

        public void PutInBasket(SessionBridgeVm sessionBridgeVm)
        {
            if (sessionBridgeVm == null) return;

            if (AlreadyAdded(sessionBridgeVm.SessionId)) return;

            _sessionBasket.Put(sessionBridgeVm.SessionId, sessionBridgeVm);
        }

        public SessionBridgeVm GetFromBasket(string sessionId)
        {
            if (string.IsNullOrEmpty(sessionId)) return null;

            if (!AlreadyAdded(sessionId)) return null;

            var sessionBridgeAsObject = _sessionBasket.Pick(sessionId);
            if (sessionBridgeAsObject == null) return null;

            return (sessionBridgeAsObject as SessionBridgeVm);
        }

        public bool AlreadyAdded(string sessionId)
        {
            bool added = _sessionBasket.PickAllKeys().Contains(sessionId);

            return added;
        }
    }
}
