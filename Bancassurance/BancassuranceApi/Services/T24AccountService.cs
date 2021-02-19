using AutoMapper;
using BancassuranceApi.Resources;
using BancassuranceApi.Utils;
using BancassuranceApi.ViewModels;
using KoClient.Core;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public class T24AccountService : IT24AccountService
    {
        private readonly IMapper _mapper;
        private readonly IConfigReader _configReader;
        private readonly KoWebClient _koWebClient;

        public T24AccountService(IMapper mapper, IConfigReader configReader)
        {
            _mapper = mapper;
            _configReader = configReader;
            _koWebClient = KoWebClient.Instance;

            KoWebClient.EnableSsl();
            KoWebClient.IgnoreSslErrors();            
        }

        public bool CanFetchAccount()
        {
            var platform = _mapper.Map<Platform>(new DefaultPlatformVm());

            _koWebClient.SetAcceptHeader("application/json");
            _koWebClient.SetContentTypeHeader("application/json");

            string serializedQuery = JsonConvert.SerializeObject(platform);

            string url = $"{_configReader.Read("BaseUrl")}{_configReader.Read("FetchUrl")}";

            string result = _koWebClient.UploadString(url, serializedQuery);

            var jsonResult = JsonConvert.DeserializeObject<JsonResult<bool>>(result);

            _koWebClient.GetWebClient().Headers.Clear();

            return jsonResult.ErrorCode == 0;
        }

        public JsonResult<AccountInfo> DoesAccountExist(string account)
        {
            var accountQuery = new AccountQuery
            {
                Account = account,
                Platform = _mapper.Map<Platform>(new DefaultPlatformVm())
            };

            _koWebClient.SetAcceptHeader("application/json");
            _koWebClient.SetContentTypeHeader("application/json");

            string serializedQuery = JsonConvert.SerializeObject(accountQuery);

            string url = $"{_configReader.Read("BaseUrl")}{_configReader.Read("AccountUrl")}";

            string result = _koWebClient.UploadString(url, serializedQuery);

            var jsonResult = JsonConvert.DeserializeObject<JsonResult<AccountInfo>>(result);

            _koWebClient.GetWebClient().Headers.Clear();

            return jsonResult;
        }

        public JsonResult<CustomerInformation> GetCustomerDetails(string customerNumber)
        {
            var customerQuery = new CustomerQuery
            {
                Number = customerNumber,
                Platform = _mapper.Map<Platform>(new DefaultPlatformVm())
            };

            _koWebClient.SetAcceptHeader("application/json");
            _koWebClient.SetContentTypeHeader("application/json");

            string serializedQuery = JsonConvert.SerializeObject(customerQuery);

            string url = $"{_configReader.Read("BaseUrl")}{_configReader.Read("DetailsUrl")}";

            string result = _koWebClient.UploadString(url, serializedQuery);

            var jsonResult = JsonConvert.DeserializeObject<JsonResult<CustomerInformation>>(result);

            _koWebClient.GetWebClient().Headers.Clear();

            return jsonResult;
        }

        public async Task<CustomerMessage> GetCustomerDetailsAsync(string accountNumber)
        {
            var result = await Task.Run(() => 
            {
                _koWebClient.SetAcceptHeader("application/json");
                _koWebClient.SetContentTypeHeader("application/json");

                string url = $"{_configReader.Read("VasPortalT24EndPointUrl")}{accountNumber}";

                string result = _koWebClient.DownloadString(url);

                var customerMessage = JsonConvert.DeserializeObject<CustomerMessage>(result);

                _koWebClient.GetWebClient().Headers.Clear();

                return customerMessage;

            });

            return result;
        }
    }
}
