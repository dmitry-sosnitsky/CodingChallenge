using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace Paymentsense.Coding.Challenge.Core.Integrations
{
    public abstract class ApiClientBase
    {
        private readonly IRestClient restClient;

        public ApiClientBase(string baseAddress, IRestClient restClient)
        {
            this.restClient = restClient ?? throw new ArgumentNullException(nameof(restClient));

            if (!Uri.TryCreate(baseAddress, UriKind.Absolute, out var uri))
            {
                throw new ArgumentException($"Invalid address '{baseAddress}'", nameof(baseAddress));
            }

            this.restClient.BaseUrl = uri;
        }

        protected async Task<TResponse> PerformRequest<TResponse>(IRestRequest request)
        {
            var response = await this.restClient.ExecuteAsync(request);

            if (!response.IsSuccessful)
            {
                throw new ApiClientException(restClient, request, response);
            }

            try
            {
                return JsonConvert.DeserializeObject<TResponse>(response.Content);
            }
            catch (Exception e)
            {
                throw new ApiClientException($"Error deserializing response into type '{typeof(TResponse).Name}'", e);
            }
        }
    }
}
